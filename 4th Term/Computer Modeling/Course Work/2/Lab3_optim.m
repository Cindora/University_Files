function [lambda, W_values] = SMO_optim_2(lambdaMin, lambdaMax, h)

% Параметры системы
mu = 6;
M = 5;
R = 6;
C1 = 100;
C2 = 10;
C3 = 20;
C4 = 15;

% Диапазон лямбда
lambda = lambdaMin:h:lambdaMax;
D = length(lambda);

W_values = zeros(D, 1);
Ns = M + R + 1;

Wmin = Inf;
kmin = 0;

for idx = 1:D
    lam = lambda(idx);
    ro = lam / mu;
    
    %% Расчёт вероятностей p
    sum_terms = 0;
    for j = 0:11
        if j == 0
            term = 1;
        elseif j <= 4
            term = ro^j / factorial(j);
        else
            term = ro^j / (factorial(4) * 5^(j - 4));
        end
        sum_terms = sum_terms + term;
    end

    p0 = 1 / sum_terms;
    p = zeros(1, 12);
    for j = 0:11
        if j == 0
            p(j+1) = p0;
        elseif j <= 4
            p(j+1) = p0 * ro^j / factorial(j);
        else
            p(j+1) = p0 * ro^j / (factorial(4) * 5^(j - 4));
        end
    end

    n = 0;
    for i = 1:Ns
        n = n + (i-1) * p(i);
    end

    Ms = 0;
    for i = 1:M
        Ms = Ms + (M - i + 1) * p(i);
    end

    Mz = M - Ms;

    r = 0;
    for i = M+2:Ns
        r = r + (i - 1 - M) * p(i);
    end

    Potk = p(Ns);
    lotk = lam * Potk;
    q = 1 - Potk;
    A_abs = q * lam;
    W_values(idx) = C1*Ms + C2*r + C3*lotk - C4*A_abs;

    fprintf('lambda = %f  W = %f\n', lam, W_values(idx));

    if W_values(idx) < Wmin
        Wmin = W_values(idx);
        kmin = idx;
    end
end

fprintf('kmin = %d    Wmin = %f\n', kmin, Wmin);

plot(lambda, W_values, 'Color', 'k', 'LineWidth', 2);
xlabel('\lambda');
ylabel('W');
title('Оптимизация W в зависимости от \lambda');

end

% Вызов функции
[lambda, W] = SMO_optim_2(1, 20, 1);
