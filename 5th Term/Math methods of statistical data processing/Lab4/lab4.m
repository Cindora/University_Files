data = [
-1.00  0.25  35.46  -9.89   18.49   44.88;
-1.00 -0.50  76.27  58.05   91.65   66.30;
-2.00  1.00  14.59  81.60   20.98   95.73;
1.00   1.00  104.72 114.60  92.27   63.53;
-3.00  1.00  159.95 204.39  235.79  199.18;
-3.00 -2.00  547.35 513.55  546.50  536.01;
-1.00  1.00  7.16   58.25  -34.94   14.56;
-3.00 -0.50  325.18 334.85  330.38  377.44;
-2.00 -0.50  151.70 181.22  189.21  212.00;
0.00  -1.25 -14.76   6.22  -25.82   38.59;
-3.00 -1.25  426.33 444.79  458.14  477.04;
-3.00  0.25  312.93 297.42  305.98  273.23;
1.00  -2.00  1.17  -11.77  -36.99  -36.28;
1.00  -1.25 -28.77 -73.41   -9.95  -41.19;
1.00  -0.50  17.16  98.05   25.02   69.29;
0.00   0.25 -2.93   50.25  -0.02   22.93;
0.00  -0.50 -20.18  -9.75   58.69   40.70;
0.00   1.00  83.03  95.71   14.71   27.10;];

x1 = data(:,1);
x2 = data(:,2);
y = data(:,3:6);

ySr = mean(y, 2);
Dsy = mean(var(y, 0, 2));

n = length(x1);
F = [ones(n,1), x1, x2, x1.^2, x1.*x2, x2.^2];

variances = var(y, 0, 2);

max_var = max(variances);
sum_var = sum(variances);
Gp = max_var / sum_var;

[p_bartlett, stats] = vartestn(y, 'TestType', 'Bartlett', 'Display', 'off');

D = inv(F' * F);
C = D * F' * ySr;   


Yp = F * C; 

k = 5; 

Dey = sum((ySr - Yp).^2) / (n - (k + 1));


Fe = Dey / Dsy;

k1 = n - 6;               
k2 = n * (size(y,2) - 1); 

alpha = 0.05;
Fc = finv(1 - alpha, k1, k2);


figure;
scatter3(x1, x2, ySr, 'filled');
hold on;

[x1g, x2g] = meshgrid(linspace(min(x1), max(x1), 30), linspace(min(x2), max(x2), 30));
Fg = [ones(numel(x1g),1), x1g(:), x2g(:), x1g(:).^2, x1g(:).*x2g(:), x2g(:).^2];
Yg = Fg * C;

surf(x1g, x2g, reshape(Yg, size(x1g)), 'FaceAlpha', 0.5);

xlabel('x1'); ylabel('x2'); zlabel('y'); title('Регрессионная модель и точки выборки');
legend('Средние значения y', 'Регрессионная поверхность');
grid on;

figure;
plot(1:n, ySr, 'bo-', 1:n, Yp, 'r*-');
xlabel('Номер наблюдения');
ylabel('Значения');
legend('Средние y', 'Прогноз Yp');
title('Сравнение фактических и прогнозируемых значений');
grid on;

F = [ones(length(x1),1), x1, x2, x1.^2, x1.*x2, x2.^2];
C = (F'*F)\(F'*ySr); % Коэффициенты регрессии
Yp = F*C;           % Прогнозируемые значения
SS_tot = sum((ySr - mean(ySr)).^2);
SS_res = sum((ySr - Yp).^2);
R2 = 1 - SS_res/SS_tot;
fprintf('Коэффициент детерминации R^2 = %.4f\n', R2);