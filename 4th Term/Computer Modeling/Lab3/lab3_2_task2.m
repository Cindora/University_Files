function potok2
clear; clc;

% Параметры моделирования
Tmax = 140;          % Максимальное время моделирования
tauSr1 = 2;        % Среднее для логнормального распределения (поток 1)
s = 1;             % Стандартное отклонение (поток 1)
tauSr2 = 4.4;        % Среднее для экспоненциального распределения (поток 2)

%% Поток 1 — логнормальное распределение
tau = lognrnd(tauSr1, s);
t1 = [tau];
while t1(end) < Tmax
    tau = lognrnd(tauSr1, s);
    t1 = [t1; t1(end) + tau];
end
if t1(end) > Tmax
    t1(end) = [];
end
N1 = length(t1);
fprintf('Кол-во событий в 1 потоке = %d\n', N1);
fprintf('Время последнего события в 1 потоке = %.2f\n', t1(end));
o1 = ones(N1,1);

%% Поток 2 — экспоненциальное распределение
tau = exprnd(tauSr2);
t2 = [tau];
while t2(end) < Tmax
    tau = exprnd(tauSr2);
    t2 = [t2; t2(end) + tau];
end
if t2(end) > Tmax
    t2(end) = [];
end
N2 = length(t2);
fprintf('Кол-во событий во 2 потоке = %d\n', N2);
fprintf('Время последнего события во 2 потоке = %.2f\n', t2(end));
o2 = ones(N2,1);

%% Объединение потоков
t12 = sort([t1; t2]);
N12 = length(t12);
o12 = ones(N12,1);

%% Графики событий (stem-графики)
figure;
subplot(3,1,1);
stem(t1, o1, 'filled');
xlabel('Время t, мин');
title('Поток 1 (логнормальное распределение)');
grid on;

subplot(3,1,2);
stem(t2, o2, 'filled');
xlabel('Время t, мин');
title('Поток 2 (экспоненциальное распределение)');
grid on;

subplot(3,1,3);
stem(t12, o12, 'filled');
xlabel('Время t, мин');
title('Объединённый поток');
grid on;

%% Графики накопленного числа событий
figure;
stairs(t1, cumsum(o1), '-', 'LineWidth', 2);    
hold on;
stairs(t2, cumsum(o2), '--r', 'LineWidth', 2);  
stairs(t12, cumsum(o12), '-.g', 'LineWidth', 2);
xlabel('Время t, мин');
ylabel('Накопленное количество событий');
title('График числа событий');
legend('Поток 1', 'Поток 2', 'Объединённый поток');
grid on;

%% Гистограмма интервалов между событиями объединённого потока
distr = diff(t12);
figure;
histogram(distr, 'BinMethod', 'fd');
xlabel('Интервалы между событиями');
ylabel('Частота');
title('Распределение интервалов времени (объединённый поток)');
grid on;

end
