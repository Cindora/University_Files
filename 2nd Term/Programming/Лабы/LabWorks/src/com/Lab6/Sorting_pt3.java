package com.Lab6;

import java.util.Arrays;
import java.util.Scanner;

public class Sorting_pt3 {
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

        int [] Zn = new int[n];
        // Формирование массива, состоящего из
        // модулей отрицательных элементов исходного массива
        int newN = 0;
        for (int el : Xn) {
            if (el < 0) {
                Zn[newN] = Math.abs(el);
                newN++;
            }
        }
        Zn = Arrays.copyOf(Xn, newN);
        //

        // Сортировка массива по убыванию
        for (int i = 0; i < newN - 1; i++) {
            for (int j = i + 1; j < newN; j++) {
                if (Zn[i] < Zn[j]) {
                    int temp = Zn[i];
                    Zn[i] = Xn[j];
                    Zn[j] = temp;
                }
            }
        }
        //

        System.out.println("Отсортированный массив Zn: " + Arrays.toString(Zn));
    }
}
