package com.Lab2.Part1;


import java.io.*;
import java.util.Scanner;

public class NumberCounter {
    private static final String INPUT_FILE = "src/com/Lab2/Part1/input.txt";   // Имя входного файла
    private static final String OUTPUT_FILE = "src/com/Lab2/Part1/output.txt"; // Имя выходного файла


    /**
     * Читает числа из указанного файла и обновляет статистику.
     *
     * @param fileName Имя файла для чтения.
     * @param stats    Объект NumberStatistics для обновления подсчетов.
     * @return true - если найдены числовые значения; false - иначе.
     */
    private static boolean readNumbersFromFile(String fileName, HashMapOperations stats) {
        File inputFile = new File(fileName);
        if (!inputFile.exists()) {
            System.out.println("Входной файл не найден: " + fileName);
            return false;
        }

        boolean hasNumbers = false;

        try (Scanner scanner = new Scanner(inputFile)) {
            while (scanner.hasNext()) {
                if (scanner.hasNextInt()) {
                    hasNumbers = true;
                    int number = scanner.nextInt();
                    stats.addNumber(number);
                } else {
                    // Пропуск нечисловых значений
                    scanner.next();
                }
            }
        } catch (FileNotFoundException e) {
            System.out.println("Ошибка при чтении файла: " + e.getMessage());
        }

        return hasNumbers;
    }

    /**
     * Записать результат в указанный файл.
     *
     * @param fileName Имя файла.
     * @param data     Данные для записи.
     */
    private static void writeResultToFile(String fileName, String data) {
        try (BufferedWriter writer = new BufferedWriter(new FileWriter(fileName))) {
            writer.write(data);
        } catch (IOException e) {
            System.out.println("Ошибка при записи в файл: " + e.getMessage());
        }
    }

    public static void main(String[] args) {
        HashMapOperations hashMapStats = new HashMapOperations();

        // Чтение чисел из файла и подсчет
        boolean hasNumbers = readNumbersFromFile(INPUT_FILE, hashMapStats);

        // Формирование результата
        String result = hashMapStats.getFormattedCounts();

        // Вывод на экран
        System.out.println(result);

        // Запись в файл
        writeResultToFile(OUTPUT_FILE, result);

        if (!hasNumbers) {
            System.out.println("Файл пуст или не содержит числовых значений.");
        } else {
            System.out.println("Результат записан в файл: " + OUTPUT_FILE);
        }
    }

}
