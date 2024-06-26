% Задача 28. Брошена игральная кость.
% Найти вероятность того, что выпадет нечётное число очков.

clc, clearvars

% Запуск таймера
tic;

% Количество бросков
N = 1000000;

% Количество нечётных результатов
count_odd = 0;

for i = 1:N
    % Бросок кубика (случ. число от 1 до 6)
    dice_roll = randi([1, 6]);
    
    % Проверка на нечётность
    if mod(dice_roll, 2) ~= 0
        count_odd = count_odd + 1;
    end
end

% Расчёт вероятности выпадения нечётного числа
P_odd = count_odd / N;

% Остановка таймера
Tm = toc;

disp(['Вероятность выпадения нечётного числа.', newline ...
    'Стат. расчёт: ', num2str(3/6), newline ...
    'Метод Монте-Карло: ', num2str(P_odd), newline ...
    'Прошло времени: ', num2str(Tm) , ' секунд.']);