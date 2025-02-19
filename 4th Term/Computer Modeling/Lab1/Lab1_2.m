% Определение диапазона и шага
x = 0:pi/200:1;

% Вычисление функции
y = atan(x) + sqrt(x) + 2;

% Построение графика функции
figure;
plot(x, y, 'b-', 'LineWidth', 2);
xlabel('x', 'FontSize', 12);
ylabel('y', 'FontSize', 12);
title('График функции y = arctg(x) + sqrt(x) + 2', 'FontSize', 14);
legend('y = arctg(x) + sqrt(x) + 2', 'FontSize', 10);
grid on;

% Нахождение экстремума функции
% Используем цикл для поиска минимума
min_value = inf; % Начальное значение для минимума
min_position = NaN; % Позиция минимума

for i = 1:length(x)
    if y(i) < min_value
        min_value = y(i);
        min_position = x(i);
    end
end

% Вывод результата
fprintf('Минимум функции достигается в точке x = %.4f и имеет значение y = %.4f\n', min_position, min_value);
