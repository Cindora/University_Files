package com.Lab7;
import java.util.Scanner;

public class Matrix_pt3 {
    public static void main(String[] args) {
        /*
          Инициализация матрицы
         */
        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите размер квадратной матрицы: ");
        int n = scanner.nextInt();
        while (n <= 0) {
            System.out.print("Ошибка ввода размера матрицы.\n" +
                    "Введите размер квадратной матрицы (N > 0): ");
            n = scanner.nextInt();
        }

        /*
          Ввод элементов матрицы
         */
        double[][] matrix = new double[n][n];
        for (int i = 0; i < n; i++) {
            System.out.print("Введите " + i + " строку матрицы: ");

            for (int j = 0; j < n; j++) {
                matrix[i][j] = scanner.nextDouble();
            }
        }
        scanner.close();

        System.out.println("Исходная матрциа: ");
        PrintMatrix(matrix,n); // Вывод матрицы

        /*
         Меняем местами главную и второстепенную диагонали
         */
        for (int i = 0; i < n; i++) {
            double temp = matrix[i][i];
            matrix[i][i] = matrix[i][n-1-i];
            matrix[i][n-1-i] = temp;
        }

        /*
         Заменяем все четные элементы, стоящие в нечетных строках, нулями
         */
        for (int i = 1; i < n; i+=2) {
                for (int j = 0; j < n; j++) {
                    if (matrix[i][j] % 2 == 0) {
                        matrix[i][j] = 0;
                    }
                }

        }

        System.out.println("\nРезультирующая матрциа: ");
        PrintMatrix(matrix,n); // Вывод матрицы
    }

    /**
     * Метод вывода квадратной матрицы в консоль.
     * @param matrix Квадратная матрица n x n.
     * @param n Размерность матрицы.
     */
    public static void PrintMatrix(double[][] matrix, int n) {
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                System.out.printf("%6.2f; ", matrix[i][j]);
            }
            System.out.println();
        }
    }
}

