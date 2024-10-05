package com.Lab2.Part2;

import java.io.*;
import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.Scanner;

public class ProcessStudents {
     /**
     * Считать данные студентов из файла и вернуть список студентов.
     *
     * @param fileName Имя входного файла.
     * @return ArrayList<Student> список студентов.
     */
    public static ArrayList<Student> readStudentsFromFile(String fileName) {
        ArrayList<Student> students = new ArrayList<>();
        File inputFile = new File(fileName);

        if (!inputFile.exists()) {
            System.out.println("Входной файл не найден: " + fileName);
            return students;
        }

        try (Scanner scanner = new Scanner(inputFile)) {
            while (scanner.hasNextLine()) {
                String line = scanner.nextLine().trim();
                if (line.isEmpty()) {
                    continue; // Пропуск пустых строк
                }

                String[] parts = line.split(",");
                if (parts.length != 2) {
                    continue; // Пропуск некорректных строк
                }

                String surname = parts[0].trim();
                int height = Integer.parseInt(parts[1].trim());

                students.add(new Student(surname, height));
            }
        } catch (FileNotFoundException e) {
            System.out.println(e.getMessage());
        }

        return students;
    }

    /**
     * Отображает список студентов в виде таблицы.
     *
     * @param students Список студентов для отображения.
     */
    public static void displayStudents(List<Student> students) {
        if (students.isEmpty()) {
            System.out.println("Нет данных для отображения.");
            return;
        }

        System.out.println("-------------------------------------------------");
        System.out.printf("%-20s | %-5s%n", "Фамилия", "Рост");
        System.out.println("-------------------------------------------------");
        for (Student student : students) {
            System.out.println(student.toString());
        }
        System.out.println("-------------------------------------------------");
    }

    /**
     * Найти двух самых высоких студентов.
     *
     * @param students Список студентов.
     * @return Список из двух студентов с наибольшим ростом.
     */
    public static List<Student> findTopTwoStudents(List<Student> students) {
        List<Student> topStudents = new ArrayList<>();

        /// Поиск роста самых высоких студентов
        int maxHeight = 0;
        int secondMaxHeight = 0;
        for (Student student : students){
            int currentStudentHeight = student.getHeight();

            if (currentStudentHeight > maxHeight) {
                secondMaxHeight = maxHeight;
                maxHeight = currentStudentHeight;
            }
            else if (currentStudentHeight == maxHeight){
                secondMaxHeight = currentStudentHeight;
            }
            else if (currentStudentHeight > secondMaxHeight) {
                secondMaxHeight = currentStudentHeight;
            }
        }

        /// Поиск студентов с самым большим ростом
        boolean firstFound = false;
        boolean secondFound = false;
        for (Student student : students)
        {
            if (!firstFound) {
                if (student.getHeight() == maxHeight) {
                    topStudents.add(student);

                    firstFound = true;
                    continue;
                }
            }
            if (!secondFound) {
                if (student.getHeight() == secondMaxHeight) {
                    topStudents.add(student);

                    secondFound = true;
                }
            }

            if (firstFound && secondFound) {
                break;
            }
        }

        return topStudents;
    }

    /**
     * Записывает список студентов в файл.
     *
     * @param fileName Имя выходного файла.
     * @param students Список студентов для записи.
     */
    public static void writeTopTwoToFile(String fileName, List<Student> students) {
        if (students.isEmpty()) {
            System.out.println("Нет данных для записи в файл.");
            return;
        }

        try (BufferedWriter writer = new BufferedWriter(new FileWriter("src/com/Lab2/Part2/" + fileName))) {
            writer.write("Два самых высоких студента:\n");
            writer.write(String.format("%-20s | %-5s%n", "Фамилия", "Рост"));
            writer.write("---------------------|-------\n");
            for (Student student : students) {
                writer.write(student.toString() + "\n");
            }
            System.out.println("Результат записан в файл: " + fileName);
        } catch (IOException e) {
            System.out.println("Ошибка при записи в файл: " + e.getMessage());
        }
    }
}

