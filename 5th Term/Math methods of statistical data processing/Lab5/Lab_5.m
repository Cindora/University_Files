% 1
t = (0:30)';
y = [-5.937,-23.304,-5.196,9.737,-12.115,-21.501,-20.707,-7.558,-15.403,-0.964,-12.758,-29.655,-11.595,1.919,7.465,12.849,13.207,17.534,29.740,30.544,21.756,20.439,28.003,43.826,55.282,47.524,72.327,57.551,68.147,77.330,83.380];

% 4
p = polyfit(t, y, 2); % коэффициенты

y_fit = polyval(p, t);

figure;
plot(t, y, 'bo', 'DisplayName', 'Исходные данные'); hold on;
plot(t, y_fit, 'r-', 'LineWidth', 2, 'DisplayName', 'Модель тренда');
xlabel('Время (t)');
ylabel('Значение y');
title('Временной ряд и модель тренда');
legend('Location', 'best');
grid on;

% 5
SS_res = sum((y - y_fit).^2);           % Сумма квадратов ошибок
SS_tot = sum((y - mean(y)).^2);         % Общая сумма квадратов
R2 = 1 - SS_res/SS_tot;
fprintf('Коэффициент детерминации R^2 = %.4f\n', R2);

% 6. Вычисление остатков
residuals = y - y_fit;

% figure;
% stem(t, residuals, 'filled');
% xlabel('Время (t)');
% ylabel('Остатки');
% title('Временной ряд остатков');
% grid on;

% 7
[R, L] = xcorr(residuals - mean(residuals), 'coeff');

figure;
stem(L, R, 'filled');
xlabel('Лаг');
ylabel('Автокорреляция');
title('АКФ остатков');
grid on;

% Линии статистической значимости
% N = length(residuals);
% hold on;
% conf_level = 1.96/sqrt(N);
% yline(conf_level, 'r--');
% yline(-conf_level, 'r--');

% Комментарий по акф:
% Если большинство значений АКФ лежит в пределах +- conf_level, корреляции отсутствуют => остатки неавтокоррелированы.

% 8. Прогноз на 5 шагов вперед
steps_ahead = (t(end)+1):(t(end)+5);
y_forecast = polyval(p, steps_ahead);

fprintf('\nПрогноз значений на 5 шагов вперед:\n');
for i = 1:length(y_forecast)
    fprintf('t = %d: y_pred = %.4f\n', steps_ahead(i), y_forecast(i));
end

% Оценка точности прогноза возможна только если есть реальные данные.
% Иначе можно вычислить доверительные интервалы или использовать стандартные ошибки, 
% что требует более сложного анализа (например, через функции regress или fitlm).