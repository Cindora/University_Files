% markov_variant13.m
% Вариант 13 — анализ и моделирование цепи Маркова

clear; close all; clc;

% --- 1) Матрица переходов P (состояния 1..6)

P = [0.3 0.6 0.1 0   0   0;
     0   0.9 0.1 0   0   0;
     0   0.5 0.5 0   0   0;
     0   0.1 0   0.4 0.3 0.2;
     0   0   0   0.4 0.1 0.5;
     0.2 0   0   0   0   0.8];


disp('P ='); disp(P);

% --- 2) Проверка квазитреугольной формы
% (видно по форме P; можно вывести подблоки)
Q = P(1:3,1:3);
R = P(4:6,4:6);

% --- 3) P^3 и вероятности состояния через 3 шага от каждого начального состояния
P3 = P^3;
disp('P^3 ='); disp(P3);


% --- 4) Вероятности через 3 шага для заданного начального вектора
pi0 = ones(1,6)/6; % пример: равномерный начальный вектор
pi3 = pi0 * P3;
disp('pi0 (initial) ='); disp(pi0);
disp('pi3 = pi0 * P^3 ='); disp(pi3);

% --- 5) Фундаментальная матрица N для транзитных состояний {1,2,3}
I3 = eye(3);
N = inv(I3 - Q)^(-1);
disp('Q ='); disp(Q);
disp('N = (I-Q)^(-1) ='); disp(N);

% --- 6) Среднее время до попадания в замкнутый класс и СКО
t = N * ones(3,1); % ожидаемое время до абсорбции (попадания в {5,6})
% второй момент:
g = N * (2 * t - ones(3,1));
varT = g - t.^2;
sdT = sqrt(varT);

disp('Expected time to absorption t (states 1..4) ='); disp(t');
disp('Std deviation of time to absorption (states 1..4) ='); disp(sdT');

% --- 7) Стационарное распределение замкнутого класса {5,6}
% решаем pi = pi * R
[V,D] = eig(R.');
% выбираем собственный вектор для собственного значения 1
[~,idx] = min(abs(diag(D) - 1));
pi_recur = real(V(:,idx));
pi_recur = pi_recur / sum(pi_recur);
disp('Stationary distribution on {5,6} ='); disp(pi_recur');

% полное предельное распределение для всех состояний:
pi_limit = [0 0 0 0 pi_recur'];
disp('Predelnoe raspredelenie (limit distribution) ='); disp(pi_limit);

% % --- 8) Показать, что P^n -> матрица со строками = pi_limit
% P100 = P^100;
% disp('P^100 (approx) ='); disp(P100);

% % --- 9) Моделирование цепи (симуляция)
% rng(1); % для воспроизводимости
% nSteps = 200; % число шагов симуляции
% s = zeros(1,nSteps);
% % начальное состояние (можно менять)
% s(1) = 1; % начинаем в состоянии 1, например
% 
% for k = 2:nSteps
%     cur = s(k-1);
%     r = rand;
%     % выбрать новое состояние, используя кумулятивную сумму
%     c = cumsum(P(cur,:));
%     new = find(r <= c, 1, 'first');
%     s(k) = new;
% end

% % --- 10) Ступенчатый график переходов между состояниями
% figure('Name','Trajectory of Markov chain (step plot)');
% stairs(0:nSteps-1, s, 'LineWidth', 1.5);
% ylim([0.5 6.5]);
% yticks(1:6);
% xlabel('Step (n)');
% ylabel('State');
% title('Trace of Markov chain (states 1..6)');
% grid on;
% 
% % Также можно построить гистограмму частот посещений последних шагов:
% figure('Name','Histogram of visits (last 100 steps)');
% histogram(s(end-100+1:end), 1:7);
% xlabel('State'); ylabel('Count'); title('Visits in last 100 steps');
