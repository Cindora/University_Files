rng(42); % Одинаковые случ. величины

% Задание 1
N = 20; M = 100;
X = exprnd(3, N, 1);      
Y = poissrnd(11, M, 1);   

% Задание 2
meanX = mean(X);  % Среднее
medianX = median(X); % Медиана
varX = var(X,0); % Дисперсия
stdX = std(X,0); % СКО
cvX = stdX/meanX; % Коэф. вариации
rangeX = max(X)-min(X); % Размах
iqrX = iqr(X); % Межкв. размах

meanY = mean(Y); 
medianY = median(Y);
varY = var(Y,0);
stdY = std(Y,0);
cvY = stdY/meanY;
rangeY = max(Y)-min(Y);
iqrY = iqr(Y);

% disp(table(meanX, medianX, varX_sample, stdX, cvX, rangeX, iqrX))
% disp(table(meanY, medianY, varY, stdY, cvY, rangeY, iqrY))

% Задание 3
% figure; ecdf(X); title('Функция распределения X (Эксп)');
% figure; ecdf(Y); title('Функция распределения Y (Пуассон)');
% figure; boxplot(X); title('Ящик-усы X (Эксп)');
% figure; boxplot(Y); title('Ящик-усы Y (Пуассон)');

% Задание 4
A = 3; B = -5; C = 7;
Z = C.*(Y.^2) + B.*Y + A;

ZnoA = C.*(Y.^2) + B.*Y;
ZnoB = C.*(Y.^2) + 1.*Y + A;
ZnoC = 1.*(Y.^2) + B.*Y + A;


% Задание 5
corrYZ = corr(Y,Z);
corrYZnoA = corr(Y,ZnoA);
corrYZnoB = corr(Y,ZnoB);
corrYZnoC = corr(Y,ZnoC);

fprintf('Коэф. корреляции: %f\n', corrYZ);
fprintf('Коэф. корреляции без А: %f\n', corrYZnoA);
fprintf('Коэф. корреляции без В: %f\n', corrYZnoB);
fprintf('Коэф. корреляции без С: %f\n', corrYZnoC);

T = table((1:N)', X, 'VariableNames', {'Index','X'});
writetable(T, 'sample_X.xlsx');

T = table((1:M)', Y, Z, 'VariableNames', {'Index','Y','Z'});
writetable(T, 'sample_YZ.xlsx');