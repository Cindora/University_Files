clc;
clear;

%% Исходные данные
r = 1/6;
lambda = 1;
mu = 6;
M = 5;
R = 6;
C1 = 100;
C2 = 10;
C3 = 20;
C4 = 15;

%% Вычисление p0-p11
% Вычисляем знаменатель для p0
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

% Вычисление p0 и массива p1-p11
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

fprintf('Значения вероятностей:\n');
for i = 0:11
    fprintf('p%d = %.15f\n', i, p(i+1));
end

%% Средние характеристики
fprintf('\nСредние характеристики:\n');
% 1. Среднее число заявок в системе
n = sum((0:11) .* p);
fprintf('Среднее число заявок в системе n = %.15f\n', n);
% 2. Простои каналов
Mc = 5*p(1) + 4*p(2) + 3*p(3) + 2*p(4) + 1*p(5);
fprintf('Число простаивающих каналов Mc = %.15f\n', Mc);
% 3. Занятые каналы
Mz = M - Mc;
fprintf('Число занятых каналов Mz = %.15f\n', Mz);
% 4. Длина очереди
r_queue = n - Mz;
fprintf('Длина очереди r = %.15f\n', r_queue);
% 5. Вероятность отказа
P_otk = p(12);
fprintf('Вероятность отказа Pотк = %.15f\n', P_otk);
% 6. Поток отказов
lambda_otk = lambda * P_otk;
fprintf('Поток отказов λотк = %.15f\n', lambda_otk);
% 7. Отн. пропускная способность
q = 1 - P_otk;
fprintf('Относительная пропускная способность q = %.15f\n', q);
% 8. Абс. пропускная способность
A = q * lambda;
fprintf('Абсолютная пропускная способность A = %.15f\n', A);
% 9. Доля необслуженных
D_neobs = P_otk;
fprintf('Доля необслуженных Dнеобс = %.15f\n', D_neobs);
% 10. Доля отказов при обслуживании
D_otk = P_otk;
fprintf('Доля отказов при обслуживании Dotk = %.15f\n', D_otk);
% 11. Время в системе
t_c = n / A;
fprintf('Время пребывания в системе tс = %.15f\n', t_c);
% 12. Время ожидания в очереди
t_ojsc = r_queue / A;
fprintf('Время ожидания в очереди tожс = %.15f\n', t_ojsc);
% 13. Время обслуживания
t_obsl = t_c - t_ojsc;
fprintf('Время обслуживания tобс = %.15f\n', t_obsl);
% 14. Затраты
W = C1 * Mc + C2 * r_queue + C3 * lambda_otk - C4 * A;
fprintf('Средние затраты W = %.15f\n', W);
















