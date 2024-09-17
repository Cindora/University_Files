package com.Lab1;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Objects;
import java.util.Scanner;

/**
 * Класс с функциональностью над классом Компьютер
 */
public class Executor {

    /**
     * Вывести инфо о компьютерах с данным процессором
     *
     * @param processorType Процессор
     */
    public static void displayByProcessor(Computers[] computers, String processorType) {
        System.out.println("Компьютеры с процессором: " + processorType);
        for (Computers comp : computers) {
            if (comp != null)
                if (comp.processor.equals(processorType)) {
                    comp.displayInfo();
                }
        }
    }

    /**
     * Метод подсчёта числа компьютеров с ОС Windows
     */
    public static void countWindowsComputers(Computers[] computers) {
        int count = 0;
        for (Computers comp : computers) {
            if (comp != null)
                if (comp.getOperatingSystem().equals("Windows")) {
                    count++;
                }
        }
        System.out.println("Количество компьютеров с ОС Windows: " + count);
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.println("Введите количество компьютеров: ");
        int countComputers = Integer.parseInt(scanner.nextLine());

        Computers[] computers = new Computers[countComputers];

        for (int i = 0; i < countComputers; i++) {
            boolean isPersonal, isLaptop;
            boolean fail = false;
            ArrayList<String> words;
            do {
                if (fail)
                    System.out.println("\nОшибка ввода, повторите: ");
                else
                    System.out.println("\nВведите (через запятую) тип компьютера(Personal/Laptop), " +
                            "название, процессор, ОС, серийный номер(число): ");

                words = new ArrayList<>(Arrays.asList(scanner.nextLine().split(", ")));
                isPersonal = Objects.equals(words.get(0), "Personal");
                isLaptop = Objects.equals(words.get(0), "Laptop");

                fail = words.size() < 5 || !(isPersonal || isLaptop);
            } while (fail);

            if (isPersonal) {
                System.out.println("\nВведите имя пользователя: ");
            } else {
                System.out.println("\nВведите дату сборки: ");
            }

            words.add(5, scanner.nextLine());

            if (isPersonal) {
                computers[i] = new Personal(words.get(1), words.get(2),
                        words.get(3), Integer.parseInt(words.get(4)), words.get(5));
            } else {
                computers[i] = new Laptop(words.get(1), words.get(2),
                        words.get(3), Integer.parseInt(words.get(4)), words.get(5));
            }

        }

        System.out.println("\nВведите процессор, для вывода информации о компьютерах с ним: ");

        Executor.displayByProcessor(computers, scanner.nextLine());

        Executor.countWindowsComputers(computers);
    }


}

