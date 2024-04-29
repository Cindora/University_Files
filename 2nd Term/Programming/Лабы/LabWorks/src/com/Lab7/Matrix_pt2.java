package com.Lab7;
import java.util.Arrays;
import java.util.Scanner;

public class Matrix_pt2 {
    public static void main(String[] args) {
        /*
          Инициализация матрицы
         */
        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите число строк и столбцов матрицы: ");
        int n = scanner.nextInt();
        int m = scanner.nextInt();
        while (n <= 0 || m <= 0) {
            System.out.print("Ошибка ввода размера матрицы.\n" +
                    "Введите число строк и столбцов матрицы (N, M > 0): ");
            n = scanner.nextInt();
            m = scanner.nextInt();
        }

        int count = 0;
        double[] outArray = new double[n*m/2];

        /*
          Ввод элементов матрицы
         */
        double[][] matrix = new double[n][m];
        for (int i = 0; i < n; i++) {
            System.out.print("Введите " + i + " строку матрицы: ");

            for (int j = 0; j < m; j++) {
                matrix[i][j] = scanner.nextDouble();

                // Количество ненулевых элементов, в четных столбцах матрицы.
                if (j % 2 == 0 && matrix[i][j] != 0) {
                    outArray[count] = matrix[i][j];
                    count++;
                }
            }
        }
        scanner.close();

        /*
          Вывод матрицы
         */
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                System.out.printf("%6.2f; ", matrix[i][j]);
            }
            System.out.println();
        }

        /*
          Dывод результата
         */
        outArray = Arrays.copyOf(outArray, count);

        System.out.println("Массив ненулевых элементов, располагающихся " +
                "в четных столбцах матрицы:\n" + Arrays.toString(outArray));
    }
}
