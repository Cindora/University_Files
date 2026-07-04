clc;
clear;

% Исходная функция
f = @(x) (x(1) - 2*x(2))^2 + (x(2) - 3)^2;

% Параметры
l = 4;
c = 2;
eps = 1.5;

% Построение начального симплекса
x1 = [-7; -7];
x2 = [-3; -7];
x3 = [-7; -3];

simplex = [x1 x2 x3];

% Таблица результатов
results = [];

k = 1;

while true
    % Вычисление значений функции
    fvals = [f(simplex(:,1)), f(simplex(:,2)), f(simplex(:,3))];
    
    % Сортировка
    [fvals, idx] = sort(fvals);
    simplex = simplex(:, idx);
    
    % Центр тяжести (без худшей точки)
    xc = (simplex(:,1) + simplex(:,2)) / 2;
    
    % Отражение
    xr = xc + c * (xc - simplex(:,3));
    
    if f(xr) < fvals(2)
        simplex(:,3) = xr;
    else
        % Сжатие
        simplex(:,3) = (simplex(:,3) + xc) / 2;
    end
    
    % Запись результатов
    results = [results; k, simplex(:,1)', f(simplex(:,1))];
    
    % Проверка остановки
    if max(abs(fvals - mean(fvals))) < eps
        break;
    end
    
    k = k + 1;
end

% Вывод
disp('Итерации:');
disp('       k        x1        x2       f(x)');
disp(results);

disp('Минимум:');
disp(simplex(:,1));
disp(f(simplex(:,1)));

% График
[x1g, x2g] = meshgrid(-10:0.5:10, -10:0.5:10);
zg = (x1g - 2*x2g).^2 + (x2g - 3).^2;

figure;
contour(x1g, x2g, zg, 30);
hold on;
plot(results(:,2), results(:,3), 'r-o', 'LineWidth', 2);
title('Поиск минимума симплекс-методом');
xlabel('x1');
ylabel('x2');
grid on;