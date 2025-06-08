function [lambda_values, W_values] = SMO_optim(lambdaMin, lambdaMax, h);

% Параметры системы
mu = 6;
M = 5;
R = 6;
C1 = 100;
C2 = 10;
C3 = 20;
C4 = 15;

% Диапазон лямбда
lambda_values = lambdaMin:h:lambdaMax;
W_values = zeros(size(lambda_values));

for i = 1:length(lambda_values)
    lambda = lambda_values(i);
    r = lambda / mu;

    % Вычисление p0–p11
    sum_terms = 0;
    for k = 0:11
        if k == 0
            term = 1;
        elseif k <= 4
            term = r^k / factorial(k);
        else
            term = r^k / (factorial(4) * 5^(k - 4));
        end
        sum_terms = sum_terms + term;
    end

    p0 = 1 / sum_terms;

    p = zeros(1, 12);
    for k = 0:11
        if k == 0
            p(k+1) = p0;
        elseif k <= 4
            p(k+1) = p0 * r^k / factorial(k);
        else
            p(k+1) = p0 * r^k / (factorial(4) * 5^(k - 4));
        end
    end

    % Средние характеристики
    n = sum((0:11) .* p);                              % Заявки в системе
    Mc = 5*p(1) + 4*p(2) + 3*p(3) + 2*p(4) + 1*p(5);   % Простои каналов
    Mz = M - Mc;                                       % Занятые каналы
    r_queue = n - Mz;                                  % Длина очереди
    P_otk = p(12);                                     % Вероятность отказа
    lambda_otk = lambda * P_otk;                       % Поток отказов
    A = lambda - lambda_otk;                           % Абс. пропускная способность

    % Затраты
    W = C1 * Mc + C2 * r_queue + C3 * lambda_otk - C4 * A;
    W_values(i) = W;

    fprintf('lambda = %.f\t W = %10.5f\n', lambda, W);
end

% Нахождение оптимального λ
[W_min, idx_min] = min(W_values);
lambda_opt = lambda_values(idx_min);

fprintf('\nМинимальные затраты: W = %.5f при λ = %.f\n', W_min, lambda_opt);

% Построение графика
figure;
plot(lambda_values, W_values, '-o', 'LineWidth', 2);
xlabel('\lambda');
ylabel('W');
title('Оптимизация затрат W по параметру \lambda');
grid on;

end


[lambda, W] = SMO_optim(1, 20, 1);
