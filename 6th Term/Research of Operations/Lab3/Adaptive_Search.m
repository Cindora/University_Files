clc;
clear;

% Начальная точка
x = [-7; -7];

% Начальный шаг
delta = 8;

% Параметры
eps = 0.001;
C = 6;

% Функция
f = @(x1,x2) (x1 - 2*x2).^2 + (x2 - 3).^2;

% Начальное значение
f_curr = f(x(1), x(2));

% Для хранения первых 20 значений
history = [];

k = 0;

while delta > eps
    k = k + 1;
    
    % Генерация новой точки
    x_new = x + delta * (2*rand(2,1)-1);
    
    f_new = f(x_new(1), x_new(2));
    
    % Сохраняем первые 20
    if k <= 20
        history = [history; x_new(1), x_new(2), f_new];
    end
    
    % Проверка улучшения
    if f_new < f_curr
        x = x_new;
        f_curr = f_new;
    else
        delta = delta / C;
    end
end

% Вывод
disp('Первые 20 точек:');
disp(array2table(history, 'VariableNames', {'x1','x2','f'}));

fprintf('\nРезультат:\n');
fprintf('x1 = %.4f, x2 = %.4f\n', x(1), x(2));
fprintf('f_min = %.6f\n', f_curr);
fprintf('Итераций: %d\n', k);