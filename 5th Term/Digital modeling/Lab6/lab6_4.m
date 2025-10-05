a = 0;
b = pi;
x_plot = linspace(a, b, 1000);      % 1000 точек на интервале
y_plot = sin(x_plot).*(cos(x_plot) - cot(x_plot)); % значения функции
figure;
plot(x_plot, y_plot, 'LineWidth', 2);
xlabel('x');
ylabel('f(x)');
title('График подынтегральной функции sin x * (cos x - ctg x) на [0, \pi]');
grid on;
