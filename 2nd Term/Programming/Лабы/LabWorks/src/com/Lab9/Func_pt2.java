package com.Lab9;

import java.util.Scanner;

public class Func_pt2 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Ввод размера массива Z
        System.out.print("Введите размер массива Z: ");
        int m = scanner.nextInt();

        // Ввод элементов массива Z
        int[] Z = new int[m];
        int[] X = new int[m];

        System.out.println("Введите элементы массива Z:");
        for (int i = 0; i < m; i++) {
            Z[i] = scanner.nextInt();
        }

        // Формирование массива X из модулей отрицательных элементов массива Z
        FillArray(X,Z);

        // Вывод результата
        if (X.length == 0) {
            System.out.println("В массиве Z нет отрицательных элементов.");
        }
        else {
            System.out.println("Массив X из модулей отрицательных элементов массива Z:");
            for (int value : X) {
                System.out.print(value + " ");
            }
        }
    }

    // Процедура для заполнения массива X из массива Z
    public static void FillArray(int[] X, int[] Z) {
        int index = 0;
        for (int el : Z) {
            if (el < 0) {
                X[index++] = Math.abs(el);
            }
        }
    }
}
