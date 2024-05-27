package com.Lab8;

import java.util.Scanner;

public class String_pt2 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        /* Ввод строки */
        System.out.print("Введите строку: ");
        String input = scanner.nextLine();

        /* Преобразование строки */
        String[] words = input.split(" "); // Разделение строки на слова
        String result = "";

        for (String word : words) {
            if (word.startsWith("A") || word.startsWith("a")) { // Начинается с A или а
                for (int i = 0; i < word.length(); i++) {
                    char ch = word.charAt(i);
                    if ("AEIOUaeiou".indexOf(ch) != -1) { // Проверка на гласную
                        result += Character.toUpperCase(ch);
                    } else {
                        result += ch;
                    }
                }
            } else {
                result += word;
            }
            result += " ";
        }

        // Вывод результата
        System.out.println("Результат: " + result);
    }
}