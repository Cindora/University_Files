package com.Lab9;

import java.util.Scanner;

public class Func_pt1 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Ввод размера массива
        System.out.print("Введите размер массива: ");
        int n = scanner.nextInt();

        // Ввод элементов массива
        int[] X = new int[n];
        System.out.println("Введите элементы массива:");
        for (int i = 0; i < n; i++) {
            X[i] = scanner.nextInt();
        }

        // Вычисление среднего значения
        double average = calculateAverage(X);

        // Подсчет количества элементов, меньших среднего
        int count = countElementsLessThanAverage(X, average);

        // Вывод результата
        System.out.println("Среднее значение: " + average);
        System.out.println("Количество элементов, меньших среднего: " + count);
    }

    public static double calculateAverage(int[] array) {
        int sum = 0;
        for (int value : array) {
            sum += value;
        }
        return (double) sum / array.length;
    }

    public static int countElementsLessThanAverage(int[] array, double average) {
        int count = 0;
        for (int value : array) {
            if (value < average) {
                count++;
            }
        }
        return count;
    }
}
