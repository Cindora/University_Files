clc; clear; close all;

%% Скриншот окна Viev Data Set (1 скрин)
%% dftool скрин из Apply (2 скрина)

%% Бланк исходный, 



%% 1. Генерация 140 значений дискретной случайной величины Bi(8, 0.7)

X_bin = binornd(8, 0.7, [140, 1]);

%% 2. Генерация 570 значений непрерывной случайной величины N(30, 9)
mu_norm = 30; % математическое ожидание
sigma_norm = 9; % стандартное отклонение
X_norm = normrnd(mu_norm, sigma_norm, [570, 1]);

%% 3.
mean_X = mean(X_norm); % математическое ожидание
fprintf('Математическое ожидание: %.4f\n', mean_X);
median_X = median(X_norm); % медиана
fprintf('Медиана: %.4f\n', median_X);
var_X = var(X_norm); % дисперсия
fprintf('Дисперсия: %.4f\n', var_X);
std_X = std(X_norm); % стандартное отклонение
fprintf('СКО: %.4f\n', std_X);
cv_X = std_X / mean_X * 100; % коэффициент вариации
fprintf('Коэффициент вариации: %.4f\n', cv_X);
range_X = max(X_norm) - min(X_norm); % размах
fprintf('Размах: %.4f\n', range_X);
interdecile_range = quantile(X_norm, 0.9) - quantile(X_norm, 0.1); % интердецильный размах
fprintf('Интердецильный размах: %.4f\n', interdecile_range);
skew_X = skewness(X_norm); % коэффициент асимметрии
fprintf('Коэффициент асимметрии: %.4f\n', skew_X);
kurt_X = kurtosis(X_norm) - 3; % коэффициент эксцесса
fprintf('Коэффициент эксцесса: %.4f\n', kurt_X);

%% 4. Построение эмпирической функции распределения
figure;
ecdf(X_norm);
title('Эмпирическая функция распределения');
xlabel('Значение');
ylabel('Частота');
grid on;

%% 5. Оценка параметров методом максимального правдоподобия и проверка критерием Колмогорова-Смирнова
% Оценка наибольшего правдоподобия нормального распределения
[mu_norm, sigma_norm] = normfit(X_norm);

% Проверка критерием Колмогорова-Смирнова. 
FR_norm = normcdf(X_norm, mu_norm, sigma_norm);
[h_norm, p_norm] = kstest(X_norm, [X_norm, FR_norm], 0.05);

if h_norm == 1
    fprintf('Норм. распр.: Гипотеза отвергнута: h: %.1f, p: %.4f\n', h_norm, p_norm);
else
    fprintf('Норм. распр.: Гипотеза принята: h: %.1f, p: %.4f\n', h_norm, p_norm);
end

% Проверка логнормального распределения
FR_logn = logncdf(X_norm, mu_norm, sigma_norm);
[h_logn, p_logn] = kstest(X_norm, [X_norm, FR_logn], 0.05);

if h_logn == 1
    fprintf('Логнорм. распр.: Гипотеза отвергнута: h: %.1f, p: %.4f\n', h_logn, p_logn);
else
    fprintf('Логнорм. распр.: Гипотеза принята: h: %.1f, p: %.4f\n', h_logn, p_logn);
end

%% 6. Интерактивный анализ распределения

% Параметры для логнормального распределения на основе норм. распределения
param_hat = mle(X_norm, 'distribution', 'lognormal');
mu_logn = param_hat(1);
sigma_logn = param_hat(2);

x_vals = linspace(min(X_norm), max(X_norm), 100);

pdf_logn = lognpdf(x_vals, mu_logn, sigma_logn);
pdf_norm = normpdf(x_vals, mean(X_norm), std(X_norm));

% Гистограмма
figure;
histogram(X_norm, 'Normalization', 'pdf', 'FaceAlpha', 0.6);
hold on;

plot(x_vals, pdf_norm, 'b--', 'LineWidth', 2);
plot(x_vals, pdf_logn, 'r-', 'LineWidth', 2);

legend('Гистограмма данных', 'Логнормальное', 'Нормальное', 'Location', 'best');
title('Нормальное и логнормальное распределения');
xlabel('Значения'); ylabel('Плотность');
hold off;

%% 7.
N_samples = [100, 1000, 10000, 100000];
N_bins = [7, 17, 117, 137];

figure;
for i = 1:length(N_samples)
    X_large = normrnd(mu_norm, sigma_norm, [N_samples(i), 1]);
    subplot(2, 2, i);
    histogram(X_large, N_bins(i));
    title(sprintf('Знач = %d, Классов = %d', N_samples(i), N_bins(i)));
    xlabel('Значение');
    ylabel('Частота');
    grid on;
end
