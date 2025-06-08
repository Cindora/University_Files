function [p] = SMO_Kolmogorov
l = 1;            % Интенсивность поступления заявок
mu = 1;           % Интенсивность обслуживания
dt = 0.01;        % Шаг по времени
T = 100;           % Общее время моделирования
Ns = 12;           % Число состояний (P0 ... P11)
Ed = eye(Ns);

% Задание матрицы коэффициентов A
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
% Инициализация
D = Ed+dt*A;
p = zeros(Ns, T);

p(:,1) = [1;0;0;0;0;0;0;0;0;0;0;0];
for t = 2:T
    p(:,t)=D*p(:,t-1);
end
t = 1:T;

% График

figure;
hold on;
lineStyles = {'-', '--', ':', '-.', '-', '--', ':', '-.', '-', '--', ':', '-.'};
for k = 1:Ns
    plot(t, p(k, :), 'Color', 'k', 'LineStyle', lineStyles{k}, 'LineWidth', 2);
end
title('Вероятности');
xlabel('t');
ylabel('P');
legend(arrayfun(@(k) sprintf('P_{%d}', k-1), 1:Ns, 'UniformOutput', false));
hold off;

end

[p] = SMO_Kolmogorov;