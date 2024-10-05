package com.Lab2.Part1;


import java.io.*;
import java.util.Scanner;

public class NumberCounter {
    private static final String INPUT_FILE_PATH =
            "src/com/Lab2/Part1/input.txt.txt";   // Путь входного файла
    private static final String OUTPUT_FILE_NAME =
            "output.txt"; // Имя выходного файла
    private static final String OUTPUT_FILE_PATH =
            "src/com/Lab2/Part1/" + OUTPUT_FILE_NAME; // Путь выходного файла


    /**
     * Читает числа из указанного файла и обновляет данные хэш-таблицы.
     *
     * @param fileName      Имя файла для чтения.
     * @param hashMapStats  Объект NumberStatistics для обновления подсчетов.
     * @return true - получены числовые значения; false - иначе.
     */
    private static boolean readFileAndUpdateHashMap(String fileName, HashMapOperations hashMapStats) {
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
                    hashMapStats.addNumber(number);
                } else {
                    // Пропуск нечисловых значений
                    scanner.next();
                }
            }
        } catch (FileNotFoundException e) {
            System.out.println(e.getMessage());
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
        boolean hasNumbers = readFileAndUpdateHashMap(INPUT_FILE_PATH, hashMapStats);

        // Формирование результата
        String result = hashMapStats.getFormattedCounts();


        if (!hasNumbers) {
            System.out.println("Входной файл пуст или не содержит числовых значений.");
        } else {
            // Вывод результата на экран
            System.out.println(result);
        }

        // Запись в файл
        writeResultToFile(OUTPUT_FILE_PATH, result);
        System.out.println("Результат записан в файл: " + OUTPUT_FILE_NAME);
    }
}
