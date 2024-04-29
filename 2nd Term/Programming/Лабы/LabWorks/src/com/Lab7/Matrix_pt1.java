package com.Lab7;
import java.util.Scanner;

public class Matrix_pt1 {
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

        /*
          Ввод элементов матрицы
         */
        double[][] matrix = new double[n][m];
        for (int i = 0; i < n; i++) {
            System.out.print("Введите " + i + " строку матрицы: ");
            for (int j = 0; j < m; j++) {
                matrix[i][j] = scanner.nextDouble();
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
          Вычисление и вывод результата
         */
        double[] maxInLine = new double[n];

        System.out.println("Номера строк и элементы, делящиеся на 5:");
        for (int i = 0; i < n; i++) {
            maxInLine[i] = Double.NEGATIVE_INFINITY;

            // Вычисление максимального элемента строки и её номера
            for (int j = 0; j < m; j++) {
                if (matrix[i][j] > maxInLine[i]) {
                    maxInLine[i] = matrix[i][j];
                }
            }

            // Проверка делимости на 5
            if (maxInLine[i] % 5 == 0) {
                System.out.printf("%2d: %3.2f; ", i, maxInLine[i]);
            }

        }
    }

    /**
     * Метод вывода матрицы в консоль.
     * @param matrix Матрица n x m.
     * @param n Число строк матрицы.
     * @param m Число столбцов матрицы.
     */
    public static void PrintMatrix(double[][] matrix, int n, int m) {
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                System.out.printf("%6.2f; ", matrix[i][j]);
            }
            System.out.println();
        }
    }
}
