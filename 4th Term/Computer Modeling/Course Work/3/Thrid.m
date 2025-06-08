function [p] = SMO_Kolmogorov
l = 1;            % Интенсивность поступления заявок
mu = 1;           % Интенсивность обслуживания
dt = 0.01;        % Шаг по времени
T = 400;           % Общее время моделирования
N = T / dt;       % Количество шагов по времени
M = 12;           % Число состояний (P0 ... P11)

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
p = zeros(N, M);
t = (0:N-1)' * dt;
p(1,:) = [1, zeros(1, M-1)];  % Начальные условия

% Метод Эйлера
for i = 2:N
    p(i,:) = p(i-1,:) + dt * (p(i-1,:) * A);
end

% Стили линий
styles = {'-', '--', ':', '-.', '-', '--', ':', '-.', '-', '--', ':', '-.'};

% Построение графиков
figure;
hold on;
for j = 1:M
    plot(t, p(:,j), styles{j}, 'LineWidth', 1.5);
end
hold off;

title('Вероятности P_0...P_{11}', 'FontName', 'Arial Unicode MS');
xlabel('t');
ylabel('P');
legend(arrayfun(@(k) sprintf('P_{%d}', k), 0:M-1, 'UniformOutput', false), 'Location', 'eastoutside');
grid on;
end

[p] = SMO_Kolmogorov;