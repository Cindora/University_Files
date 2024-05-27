package com.Lab9;

import java.util.ArrayList;
import java.util.Scanner;

public class Func_pt2 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Ввод размера массива Z
        System.out.print("Введите размер массива Z: ");
        int m = scanner.nextInt();

        // Ввод элементов массива Z
        int[] Z = new int[m];
        System.out.println("Введите элементы массива Z:");
        for (int i = 0; i < m; i++) {
            Z[i] = scanner.nextInt();
        }

        // Формирование массива X из модулей отрицательных элементов массива Z
        int[] X = createArrayFromNegativeModules(Z);

        // Вывод результата
        System.out.println("Массив X из модулей отрицательных элементов массива Z:");
        for (int value : X) {
            System.out.print(value + " ");
        }
    }

    public static int[] createArrayFromNegativeModules(int[] array) {
        // Подсчет количества отрицательных элементов в массиве Z
        int negativeCount = 0;
        for (int value : array) {
            if (value < 0) {
                negativeCount++;
            }
        }

        // Создание массива X для модулей отрицательных элементов
        int[] X = new int[negativeCount];
        int index = 0;
        for (int value : array) {
            if (value < 0) {
                X[index++] = Math.abs(value);
            }
        }

        return X;
    }
}
