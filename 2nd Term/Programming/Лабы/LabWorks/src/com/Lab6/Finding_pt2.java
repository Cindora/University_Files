package com.Lab6;

import java.util.Arrays;
import java.util.Scanner;

public class Finding_pt2 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Введите количество элементов массива: ");
        int n = scanner.nextInt();
        while (n <= 0) {
            System.out.print("Ошибка ввода размера массива (N > 0) ");
            n = scanner.nextInt();
        }
        int[] Xn = new int[n];

        System.out.println("Введите элементы массива:");
        for (int i = 0; i < n; i++) {
            Xn[i] = scanner.nextInt();
        }

        System.out.print("Введите интервал [A; B]: ");
        int A = scanner.nextInt();
        while (A < 0 || A >= n) {
            System.out.print("Ошибка ввода начальной границы. Повторите: ");
            A = scanner.nextInt();
        }

        int B = scanner.nextInt();
        while (B < A || B >= n) {
            System.out.print("Ошибка ввода конечной границы. Повторите: ");
            B = scanner.nextInt();
        }

        System.out.print("Введите число D: ");
        int D = scanner.nextInt();

        //Вычисление суммы элементов массива в интервале [A;B], не равных D
        int sum = 0;
        for (int el : Xn) {
            if (A <= el && el <= B && el != D) {
                sum += el;
            }
        }
        System.out.println("Сумма элементов массива в интервале [" + A + "; " + B + "], не равных " + D + ": " + sum);
        //

        // Удаление первых двух положительных элементов массива с четными индексами
        int newN = 0;
        int countElDeleted = 0;

        for (int i = 0; i < n; i++) {
            if (i % 2 != 0 || Xn[i] <= 0 || countElDeleted >= 2) {
                Xn[newN] = Xn[i];
                newN++;
            } else {
                countElDeleted++;
            }
        }
        Xn = Arrays.copyOf(Xn, newN);
        //

        System.out.println("Массив после удаления первых двух положительных элементов с четными индексами: ");
        for (int el : Xn) {
            System.out.print(el + "; ");
        }
    }
}