clc, clearvars

% Запуск таймера
tic;

% Количество бросков
N = 10000000;

count = 0;

% Бракованные книги

for i = 1:N
    % Выбор одной книги из 100
    selected_book = randi([1,100]);

    % Проверка, что выбранная книга бракованная
    if selected_book <= 5
        count = count + 1;
    end
end

% Вероятность взять бракованную книгу
P_brk = count / N;

% Остановка таймера
Tm = toc;

disp(['Вероятность попадания выстрела в белый сектор.', newline ...
    'Стат. расчёт: ', num2str(0.05), newline ...
    'Метод Монте-Карло: ', num2str(P_brk), newline ...
    'Прошло времени: ', num2str(Tm) , ' секунд.']);