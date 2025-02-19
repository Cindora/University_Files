% Задание 1: Решение системы линейных алгебраических уравнений

% Определение коэффициентов и свободных членов
A = [-1 16 15 -5; 
    19 19 -2 11; 
    -8 -17 15 3; 
    14 12 11 17];

b = [-18; 13; -11; -9];

% 1. Метод обратной матрицы
x_inverse = inv(A) * b;

% 2. Метод Гаусса
x_gauss = A\b;

% 3. Стандартные функции MATLAB
x_standard = linsolve(A, b);

% Проверка решений
check_inverse = A * x_inverse;
check_gauss = A * x_gauss;
check_standard = A * x_standard;

% Вывод результатов
fprintf('Решение методом обратной матрицы:\n');
disp(x_inverse);
fprintf('Проверка: A * x_inverse = \n');
disp(check_inverse);

fprintf('Решение методом Гаусса:\n');
disp(x_gauss);
fprintf('Проверка: A * x_gauss = \n');
disp(check_gauss);

fprintf('Решение стандартной функцией MATLAB:\n');
disp(x_standard);
fprintf('Проверка: A * x_standard = \n');
disp(check_standard);

% Задание 2: Нахождение корней полинома

% Определение коэффициентов полинома
coeffs = [-8, 0, 5, 0]; 

% Нахождение корней полинома
roots_poly = roots(coeffs);

% Вывод корней
fprintf('Корни полинома:\n');
disp(roots_poly);

% Проверка корней с помощью графика
x_range = linspace(-2, 2, 100);
y_values = polyval(coeffs, x_range);

% Построение графика полинома
figure;
plot(x_range, y_values, 'r-', 'LineWidth', 2);
hold on;
plot(roots_poly, zeros(size(roots_poly)), 'bo', 'MarkerSize', 10, 'MarkerFaceColor', 'b');
xlabel('x', 'FontSize', 12);
ylabel('y', 'FontSize', 12);
title('График полинома y = -8x^3 + 5x', 'FontSize', 14);
grid on;
legend('y = -8x^3 + 5x', 'Корни полинома', 'FontSize', 10);
hold off;
