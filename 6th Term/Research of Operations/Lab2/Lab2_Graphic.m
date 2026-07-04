clc;
clear;

% Исходная функция
f = @(x) (x(1) - 2*x(2))^2 + (x(2) - 3)^2;

% Параметры
l = 4;
gamma = 2;   % растяжение (c)
beta = 0.5;  % сжатие
eps = 1.5;

% Начальная точка
x0 = [-7; -7];

% Формирование начального симплекса
n = length(x0);
simplex = zeros(n, n+1);
simplex(:,1) = x0;

for i = 2:n+1
    e = zeros(n,1);
    e(i-1) = 1;
    simplex(:,i) = x0 + l*e;
end

iter = 0;

fprintf('Iter\t x1\t x2\t f(x)\n');

while true
    iter = iter + 1;
    
    % Вычисление значений
    values = zeros(1,n+1);
    for i = 1:n+1
        values(i) = f(simplex(:,i));
    end
    
    % Сортировка
    [values, idx] = sort(values);
    simplex = simplex(:,idx);
    
    % Вывод лучшей точки
    fprintf('%d\t %.2f\t %.2f\t %.2f\n', iter, simplex(1,1), simplex(2,1), values(1));
    
    % Проверка остановки
    if std(values) < eps
        break;
    end
    
    % Центр тяжести без худшей точки
    xc = mean(simplex(:,1:n), 2);
    
    % Отражение
    xr = xc + (xc - simplex(:,end));
    
    if f(xr) < values(1)
        % Растяжение
        xe = xc + gamma*(xr - xc);
        if f(xe) < f(xr)
            simplex(:,end) = xe;
        else
            simplex(:,end) = xr;
        end
    elseif f(xr) < values(n)
        simplex(:,end) = xr;
    else
        % Сжатие
        xs = xc + beta*(simplex(:,end) - xc);
        simplex(:,end) = xs;
    end
end

disp('Минимум найден в точке:');
disp(simplex(:,1));
disp('Значение функции:');
disp(f(simplex(:,1)));

% Построение графика
[x1, x2] = meshgrid(-10:0.5:10, -10:0.5:10);
z = (x1 - 2*x2).^2 + (x2 - 3).^2;

figure;
contour(x1, x2, z, 20);
hold on;
plot(simplex(1,1), simplex(2,1), 'ro', 'MarkerSize', 10, 'LineWidth', 2);
title('Линии уровня функции');
xlabel('x1');
ylabel('x2');
grid on;