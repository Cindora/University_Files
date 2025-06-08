function [p, n, Ms, Mz, r, Potk, lotk, q, A_abs, Dneobsl, Dotk, t_s, toq, tobs, W] = SMO_Kolmogorov_raschet;

% Параметры
l = 1;
mu = 1;
dt = 0.01;
T = 40;
N = T/dt;
M = 12;

% Матрица A
A = [...
    -l       mu         0        0       0       0       0       0       0       0       0       0;
     l    -(l+mu)     2*mu       0       0       0       0       0       0       0       0       0;
     0       l      -(l+2*mu)  3*mu      0       0       0       0       0       0       0       0;
     0       0         l     -(l+3*mu)  4*mu     0       0       0       0       0       0       0;
     0       0         0        l    -(l+4*mu)  5*mu     0       0       0       0       0       0;
     0       0         0        0       l    -(l+5*mu)  5*mu     0       0       0       0       0;
     0       0         0        0       0       l    -(l+5*mu)  5*mu     0       0       0       0;
     0       0         0        0       0       0       l    -(l+5*mu)  5*mu     0       0       0;
     0       0         0        0       0       0       0       l    -(l+5*mu)  5*mu     0       0;
     0       0         0        0       0       0       0       0       l    -(l+5*mu)  5*mu     0;
     0       0         0        0       0       0       0       0       0       l    -(l+5*mu)  5*mu;
     0       0         0        0       0       0       0       0       0       0       l     -5*mu
];

% Начальные условия
p = zeros(N, M);
p(1,1) = 1;

% Решение
for t = 2:N
    p(t,:) = p(t-1,:) + dt * (p(t-1,:) * A);
end

% Расчёты
time = (0:N-1)*dt;
n = zeros(N,1); Ms = zeros(N,1); Mz = zeros(N,1); r = zeros(N,1);
Potk = zeros(N,1); lotk = zeros(N,1); q = zeros(N,1); A_abs = zeros(N,1);
Dneobsl = zeros(N,1); Dotk = zeros(N,1); t_s = zeros(N,1);
toq = zeros(N,1); tobs = zeros(N,1); W = zeros(N,1);

C1 = 100; C2 = 10; C3 = 20; C4 = 15;

for i = 1:N
    pi = p(i,:);
    n(i) = sum((0:11) .* pi);
    Ms(i) = 6*pi(1) + 5*pi(2) + 4*pi(3) + 3*pi(4) + 2*pi(5) + pi(6);
    Mz(i) = 6 - Ms(i);
    r(i) = 0*pi(1) + 0*pi(2) + 0*pi(3) + 0*pi(4) + 0*pi(5) + 0*pi(6) + pi(7) + 2*pi(8) + 3*pi(9) + 4*pi(10) + 5*pi(11) + 6*pi(12);
    Potk(i) = pi(12);
    lotk(i) = l * Potk(i);
    q(i) = 1 - Potk(i);
    A_abs(i) = q(i) * l;
    Dneobsl(i) = lotk(i) / l;
    Dotk(i) = Dneobsl(i);
    t_s(i) = n(i) / A_abs(i);
    toq(i) = r(i) / A_abs(i);
    tobs(i) = t_s(i) - toq(i);
    W(i) = C1*Mz(i) + C2*r(i) + C3*lotk(i) - C4*A_abs(i);
end

t_indices = 100:100:4000;

% Сохраняем значения переменных в указанные моменты времени
n_t       = n(t_indices);
Ms_t      = Ms(t_indices);
Mz_t      = Mz(t_indices);
r_t       = r(t_indices);
Potk_t    = Potk(t_indices);
lotk_t    = lotk(t_indices);
q_t       = q(t_indices);
A_t       = A_abs(t_indices);
Dneobsl_t = Dneobsl(t_indices);
Dotk_t    = Dotk(t_indices);
t_s_t     = t_s(t_indices);
toq_t     = toq(t_indices);
tobs_t    = tobs(t_indices);
W_t       = W(t_indices);

% Передаём переменные в workspace
assignin('base', 'n_t', n_t);
assignin('base', 'Ms_t', Ms_t);
assignin('base', 'Mz_t', Mz_t);
assignin('base', 'r_t', r_t);
assignin('base', 'Potk_t', Potk_t);
assignin('base', 'lotk_t', lotk_t);
assignin('base', 'q_t', q_t);
assignin('base', 'A_t', A_t);
assignin('base', 'Dneobsl_t', Dneobsl_t);
assignin('base', 'Dotk_t', Dotk_t);
assignin('base', 't_s_t', t_s_t);
assignin('base', 'toq_t', toq_t);
assignin('base', 'tobs_t', tobs_t);
assignin('base', 'W_t', W_t);

data = [n Ms Mz r Potk lotk q A_abs Dneobsl Dotk t_s toq tobs W];

% Построение графиков
titles = {'Число заявок в системе','Число свободных каналов','Число занятых каналов','Длина очереди','Вероятность отказа', 'Поток отказов','Относительная пропускная способность','Абсолютная пропускная способность','Доля необслуженных заявок', 'Доля заявок, получивших отказ в обслуживании','Время пребывания заявки в системе', 'Время ожидания в очереди', 'Время обслуживания','Затраты на функционирование системы'};
ylabels = {'n','Ms','Mz','r','P_{отк}', 'λ_{отк}','q','A','D_{необсл}','D_{отк}','t_{с}',     't_{оч}','t_{обс}','W'};

figure;
for i = 1:6
    subplot(2,3,i);
    plot(time, data(:,i), 'LineWidth', 1.5);
    title(titles{i}); xlabel('t'); ylabel(ylabels{i}, 'Rotation', 0); 
end
figure;
for i = 7:14
    subplot(3,3,i-6);
    plot(time, data(:,i), 'LineWidth', 1.5);
    title(titles{i}); xlabel('t'); ylabel(ylabels{i}, 'Rotation', 0);
end

end

[p, n, Ms, Mz, r, Potk, lotk, q, A, Dneobsl, Dotk, t_s, toq, tobs, W] = SMO_Kolmogorov_raschet;