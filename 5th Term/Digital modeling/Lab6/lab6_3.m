% данные интеграла для 3 повторов
I_estimate = [0.0801, 0.0313, -0.0284];
m = 3; % количество повторов
meanI = mean(I_estimate); % среднее значение
stdI = std(I_estimate); % стандартное отклонение (выборочное)
% параметры
df = 2; % степень свободы
alpha = 0.1;
tCrit = 2.9200; % t-критическое значение для df=2 и alpha=0.10
% расчет доверительного интервала
delta = tCrit * stdI / sqrt(m);
lowerBound = meanI - delta;
upperBound = meanI + delta;
fprintf('Доверительный интервал (90%%): [%.6f; %.6f]\n', lowerBound, upperBound);
