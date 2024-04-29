package com.Lab6;
import java.util.Scanner;

public class Array_pt1 {
    public static void main(String[] args) {
        // Ввод массива
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
        //

        // Вычислеие среднего значения
        double sum = 0;
        for (int el : Xn) {
            sum += el;
        }
        double avg = sum / n;
        //

        // Количество элементов, меньших среднего
        int countLessThanAvg = 0;
        for (int el : Xn) {
            if (el < avg) {
                countLessThanAvg++;
            }
        }
        System.out.println("Количество элементов массива, меньших среднего: " + countLessThanAvg);
        //

        // Значения и номера элементов, делящихся на 3
        System.out.println("Элементы, делящиеся на 3 без остатка:");
        for (int i = 0; i < n; i++) {
            if (Xn[i] % 3 == 0) {
                System.out.println("Элемент: " + Xn[i] + ". Номер: " + i);
            }
        }
        //
    }
}
