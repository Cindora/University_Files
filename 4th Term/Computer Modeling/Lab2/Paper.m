clc;
clear;

%% === ШАГ 0 ===
% Генерация дискретной случайной величины (биномиальное распределение)
binom_data = binornd(8, 0.7, [140, 1]);

% Генерация непрерывной случайной величины (нормальное распределение)
mu_true = 30;
sigma_true = 9;
norm_data = normrnd(mu_true, sigma_true, [570, 1]);

%% === ШАГ 1 ===
% Метод максимального правдоподобия для нормального распределения
mu_hat = mean(norm_data);
sigma_hat = std(norm_data);

% Проверка КС-критерием (нормальное распределение)
[h_norm, p_norm, ksstat_norm] = kstest((norm_data - mu_hat) / sigma_hat);

fprintf('Проверка соответствия нормальному распределению:\n');
fprintf('Оценка параметров: mu = %.2f, sigma = %.2f\n', mu_hat, sigma_hat);
fprintf('КС-статистика: %.4f, p-значение: %.4f\n', ksstat_norm, p_norm);
if h_norm == 0
    disp('Нулевая гипотеза НЕ отвергается (соответствует нормальному распределению).');
else
    disp('Нулевая гипотеза отвергается.');
end

% Проверка альтернативного распределения: экспоненциальное
lambda_hat = 1 / mean(norm_data);
pd_exp = makedist('Exponential', 'mu', 1/lambda_hat);

h_exp = kstest(norm_data, 'CDF', pd_exp);

fprintf('\nПроверка соответствия экспоненциальному распределению:\n');
fprintf('Оценка параметра lambda = %.4f\n', lambda_hat);

if h_exp == 0
    disp('Нулевая гипотеза НЕ отвергается (возможно экспоненциальное распределение).');
else
    disp('Нулевая гипотеза отвергается.');
end


% %% === ШАГ 2 ===
% % Вызов интерактивного инструмента анализа данных
% disp('Открытие интерактивного инструмента fitdist...');
% figure;
% histfit(norm_data, 20, 'normal'); hold on;
% 
% % Добавим экспоненциальное распределение на гистограмму
% x_vals = linspace(min(norm_data), max(norm_data), 100);
% y_exp = pdf(pd_exp, x_vals);
% y_exp = y_exp * (max(histcounts(norm_data))/max(y_exp));  % масштабируем для наложения
% plot(x_vals, y_exp, 'r--', 'LineWidth', 2);
% legend('Гистограмма + Нормальное', 'Экспоненциальное распределение');


% %% === ШАГ 3 ===
% sample_sizes = [100, 1000, 10000, 100000];
% num_bins = [7, 17, 117, 137];
% 
% for i = 1:length(sample_sizes)
%     data = normrnd(mu_true, sigma_true, [sample_sizes(i), 1]);
%     figure;
%     histogram(data, num_bins(i), 'Normalization', 'pdf');
%     title(sprintf('Гистограмма (%d значений, %d классов)', sample_sizes(i), num_bins(i)));
%     xlabel('Значения'); ylabel('Плотность');
%     hold on;
%     x = linspace(min(data), max(data), 100);
%     y = normpdf(x, mu_true, sigma_true);
%     plot(x, y, 'r', 'LineWidth', 2);
%     legend('Гистограмма', 'Теоретическая плотность');
% end
