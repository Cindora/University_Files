% Данные
y = [99.959,80.524,78.265,79.382,77.418,55.409,53.154,58.659,43.037,36.004,...
     26.689,21.354,31.380,11.483,12.727,-0.338,13.237,7.292,7.215,0.931,...
     -7.421,-1.653,-14.041,-4.586,22.272,16.723,9.878,7.181,13.066,11.095,19.318]';
t = (0:length(y)-1)';

% Квадратичная аппроксимация (полином 2)
p = polyfit(t, y, 2);   % p = [a b c]
y_pred = polyval(p, t);

% R^2
SS_res = sum((y - y_pred).^2);
SS_tot = sum((y - mean(y)).^2);
R2 = 1 - SS_res/SS_tot;

% Остатки и автокорреляция
resid = y - y_pred;
% ACF (до лага 20)
maxlag = min(20, length(y)-1);
[acfvals, lags] = autocorr(resid, 'NumLags', maxlag); 

% Графики
figure;
plot(t, y, 'o-', t, y_pred, '--x'); legend('Исходные','Квадрат. тренд'); title(['R^2 = ' num2str(R2)]);
xlabel('t'); ylabel('y');

figure;
plot(t, resid, 'o-'); yline(0,'--'); title('Остатки');

figure;
stem(0:maxlag, acfvals); xlabel('лаг'); ylabel('автокорреляция'); title('автокорреляция');
