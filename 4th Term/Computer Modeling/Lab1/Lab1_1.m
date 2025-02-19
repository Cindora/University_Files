A = [-8, -8, 12, -8; 
     -5, -4, 14, -4; 
     9, 6, -4, 18; 
     6, 1, -11, 3];

B = [10, -2, 16, -9; 
     7, 16, -9, -5;
     -19, -8, 19, 10;
     3, 4, -9, 12];

p = 2;

%% 1. Сложение и умножение матриц
sum_AB = A + B;
prod_AB = A * B;

%% 2. Поэлементные операции
elementwise_mult = A .* B;
elementwise_div = A ./ B;

power_A = A .^ p;
power_B = B .^ p;

%% 3. Обратные матрицы, проверка
inv_A = inv(A);
inv_B = inv(B);

check_A = A * inv_A;
check_B = B * inv_B;

%% 4. Транспонировать матрицы
transposed_A = A';
transposed_B = B';

%% 5. Номера и значения элементов, удовлетворяющих условию
% Пример условия: элементы больше 0
[row_A, col_A, values_A] = find(A <= 0);
[row_B, col_B, values_B] = find(B <= 0);

% Вывод результатов
disp('Сложение матриц A и B:');
disp(sum_AB);

disp('Умножение матриц A и B:');
disp(prod_AB);

disp('Поэлементное умножение матриц A и B:');
disp(elementwise_mult);

disp('Поэлементное деление матриц A и B:');
disp(elementwise_div);

disp(['Матрица A в степени ' num2str(p) ':']);
disp(power_A);

disp(['Матрица B в степени ' num2str(p) ':']);
disp(power_B);

disp('Обратная матрица A:');
disp(inv_A);

disp('Обратная матрица B:');
disp(inv_B);

disp('Проверка A * inv(A):');
disp(check_A);

disp('Проверка B * inv(B):');
disp(check_B);

disp('Транспонированная матрица A:');
disp(transposed_A);

disp('Транспонированная матрица B:');
disp(transposed_B);

disp('Номера и значения элементов A > 0:');
disp(table(row_A, col_A, values_A));

disp('Номера и значения элементов B > 0:');
disp(table(row_B, col_B, values_B));
