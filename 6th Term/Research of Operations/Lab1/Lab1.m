clc; clear;

x = 0:0.05:10;
y = abs(x+1) + 1./abs(x+1);

plot(x, y, 'LineWidth', 2);
grid on;
xlabel('x');
ylabel('f(x)');
title('f(x) = |x+1| + 1/|x+1|');