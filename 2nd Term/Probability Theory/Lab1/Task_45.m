% При включении зажигания двигатель начинает работать с вероятностью Р.
% Найти вероятность того, что двигатель начнѐт работать при втором включении зажигания.

clc, clearvars

% Количество бросков
N = 10000;

% Вероятность запуска двигателя
P = 0.8;

% Число запусков двигателя при втором включении
count_second = 0;

for i = 1:N
    % Получение случ. числа от 0.0 до 1.0 для проверки запуска двигателя на
    % первой попытке.
    engine_start = rand;
    
    % Проверка, что двигатель запустился в первый раз
    if engine_start <= P
        % Двигатель запустился

        % Получение случ. числа от 0.0 до 1.0 для проверки запуска двигателя на
        % второй попытке.
        engine_start = rand;
        
        if engine_start <= P
            % Двигатель запустился на второй раз.
            count_second = count_second + 1;
        end
    end
end

% Вероятность запуска при втором включении зажигания.
P_second = count_second / N;

disp(['Вероятность запуска двигателя при втором включении зажигания.', newline ...
    'Стат. расчёт: ', num2str(P*P), newline ...
    'Метод Монте-Карло: ', num2str(P_second)]);