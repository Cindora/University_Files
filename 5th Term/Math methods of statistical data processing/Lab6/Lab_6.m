clear; clc; close all;

A  = -0.3;
B  = 0.001;
C  = -0.2;
D  = 0.2;
U  = 24;
f1 = 7;
V  = 9;
f2 = 19;
w  = 0;                % сдвиг фазы
Tm = 400;
dt = 0.01;             % шаг

t = (0:Tm)';           % индекс времени
tt = t * dt;           % реальное время

Z = -14 + (14 - (-14)) * rand(size(t));

x = zeros(size(t));
x(1) = 0;
x(2) = 0;

%% Генерация временного ряда
for k = 3:length(t)
    x(k) = A*tt(k) + B*tt(k)^2 + ...
           C*x(k-1) + D*x(k-2) + ...
           U*sin(2*pi*f1*tt(k)) + ...
           V*sin(2*pi*f2*tt(k) - w) + ...
           Z(k);
end

%% Модель тренда
poly_deg = 2;
trend_coeff = polyfit(tt, x, poly_deg);
trend = polyval(trend_coeff, tt);

e = x - trend;

% Графики
figure;
subplot(3,1,1);
plot(tt,x); title('Временной ряд x(t)');

subplot(3,1,2);
plot(tt,trend,'LineWidth',2); title('Тренд');

subplot(3,1,3);
plot(tt,e); title('Остаточный ВР e(t)');

%% Автокорреляционная функция

[acf,lags] = xcorr(e,'coeff');

figure;
plot(lags,acf);
title('Автокорреляционная функция e(t)');
xlabel('Лаг'); ylabel('АКФ');
grid on;

%% Спектральная плотность

N = length(e);
E = fft(e);
P = abs(E).^2 / N;          

freq = (0:N-1)/(N*dt);

figure;
plot(freq(1:N/2), P(1:N/2));
title('Спектральная плотность остаточного ВР');
xlabel('Частота'); ylabel('Плотность');
grid on;

%% Периоды основных волн ВР

[pks, locs] = findpeaks(P(1:N/2), freq(1:N/2));

[pks_sorted, idx] = sort(pks, 'descend');
dominant_freqs = locs(idx(1:5)); 

periods = 1 ./ dominant_freqs;

disp('Основные частоты:');
disp(dominant_freqs);

disp('Соответствующие периоды:');
disp(periods);
