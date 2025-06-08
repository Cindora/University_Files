function [p, n, Ms, Mz, r, Potk, lotk, q, A_abs, Dneobsl, Dotk, t_s, toq, tobs, W] = SMO_Kolmogorov_raschet;

% Параметры
ro = 1/6;
mu = 6;
M = 5;
R = 6;
C1 = 100;
C2 = 10;
C3 = 20;
C4 = 15;
l = 1;
dt = 0.01;
T = 400;
Ns = 12;
Ed = eye(Ns);

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
p = zeros(Ns, T);
D = Ed + dt*A;

p(:,1) = [1;0;0;0;0;0;0;0;0;0;0;0];
for t = 2:T
    p(:,t)=D*p(:,t-1);
end
t = 1:T;

n = zeros(T, 1); Ms = zeros(T, 1); Mz = zeros(T, 1); r = zeros(T, 1); 
Potk = zeros(T, 1); lotk = zeros(T, 1); q = zeros(T, 1); A_abs = zeros(T, 1); 
Dneobsl = zeros(T, 1); Dotk = zeros(T, 1); t_s = zeros(T, 1); toq = zeros(T, 1); 
tobs = zeros(T, 1); W = zeros(T, 1); 

% Решение
for t = 1:T
    for i=1:Ns
        n(t,1)=n(t,1)+(i-1)*p(i,t);
    end

    for i=1:M
        Ms(t,1)=Ms(t,1)+(M-i+1)*p(i,t);
    end
  
    Mz(t,1)=M-Ms(t,1);
    for i=M+2:Ns
        r(t,1)=r(t,1)+(i-1-M)*p(i,t);
    end

    Potk(t,1)=p(Ns,t);
    lotk(t,1)=l*Potk(t,1);
    q(t,1)=1-Potk(t,1);
    A_abs(t,1)=q(t,1)*l;
    Dneobsl(t,1)=lotk(t,1)/l;
    Dotk(t,1)=lotk(t,1)/1;
    ts(t,1)=n(t,1)/A_abs(t,1);
    tog(t,1)=r(t,1)/A_abs(t,1);
    tobs(t,1)=ts(t,1)-tog(t,1);
    W(t,1)=C1*Ms(t,1)+C2*r(t,1)+C3*lotk(t,1)-C4*A_abs(t,1);

end
t=1:T;

% figure; plot(t,n, 'Color', 'k', 'LineWidth', 2); title('Число заявок в системе'); xlabel('t'); ylabel('n', 'Rotation', 0);
% figure; plot(t,Ms, 'Color', 'k', 'LineWidth', 2); title('Число свободных каналов'); xlabel('t'); ylabel('Ms', 'Rotation', 0);
% figure; plot(t,Mz, 'Color', 'k', 'LineWidth', 2); title('Число занятых каналов'); xlabel('t'); ylabel('Mz', 'Rotation', 0);
% figure; plot(t,r, 'Color', 'k', 'LineWidth', 2); title('Длина очереди'); xlabel('t'); ylabel('r', 'Rotation', 0);
% figure; plot(t,Potk, 'Color', 'k', 'LineWidth', 2); title('Вероятность отказа'); xlabel('t'); ylabel('P_{отк}', 'Rotation', 0);
% figure; plot(t,lotk, 'Color', 'k', 'LineWidth', 2); title('Поток отказов'); xlabel('t'); ylabel('λ_{отк}', 'Rotation', 0);
% figure; plot(t,q, 'Color', 'k', 'LineWidth', 2); title('Относительная пропускная способность'); xlabel('t'); ylabel('q', 'Rotation', 0);
% figure; plot(t,A_abs, 'Color', 'k', 'LineWidth', 2); title('Абсолютная пропускная способность'); xlabel('t'); ylabel('A_abs', 'Rotation', 0);
% figure; plot(t,Dneobsl, 'Color', 'k', 'LineWidth', 2); title('Доля необслуженных заявок'); xlabel('t'); ylabel('D_{необсл}', 'Rotation', 0);
% figure; plot(t,Dotk, 'Color', 'k', 'LineWidth', 2); title('Доля заявок, получивших отказ в обслуживании'); xlabel('t'); ylabel('D_{отк}', 'Rotation', 0);
% figure; plot(t,ts, 'Color', 'k', 'LineWidth', 2); title('Время пребывания заявки в системе'); xlabel('t'); ylabel('t_{с}', 'Rotation', 0);
% figure; plot(t,tog, 'Color', 'k', 'LineWidth', 2); title('Время ожидания в очереди'); xlabel('t'); ylabel('t_{оч}', 'Rotation', 0);
% figure; plot(t,tobs, 'Color', 'k', 'LineWidth', 2); title('Время обслуживания'); xlabel('t'); ylabel('t_{обс}', 'Rotation', 0);
% figure; plot(t,W, 'Color', 'k', 'LineWidth', 2); title('Затраты на функционирование системы'); xlabel('t'); ylabel('W', 'Rotation', 0);


end

[p, n, Ms, Mz, r, Potk, lotk, q, A, Dneobsl, Dotk, t_s, toq, tobs, W] = SMO_Kolmogorov_raschet;