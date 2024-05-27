package com.Lab8;

import java.util.Scanner;

public class String_pt1 {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        /* Ввод строки */
        System.out.print("Введите строку: ");
        String input = scanner.nextLine();

        /* Ввод количества удаляемых цифровых символов */
        System.out.print("Введите количество цифровых символов для удаления: ");
        int K = scanner.nextInt();

        /* Удаление цифровых символов */
        char[] tmpArray = new char[input.length()];
        int digitCount = 0; // Количество найденных цифр
        int index = 0; // Текущее положение каретки

        for (int i = 0; i < input.length(); i++) {
            char ch = input.charAt(i);
            if (Character.isDigit(ch) && digitCount < K) {
                digitCount++;
            } else {
                tmpArray[index++] = ch;
            }
        }

        String result = new String(tmpArray, 0, index); // Массив в строку

        /* Вывод результата */
        System.out.println("Результат: " + result);
    }
}

