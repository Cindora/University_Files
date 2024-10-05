package com.Lab2.Part2;

// File: Main.java

import java.util.ArrayList;
import java.util.List;

public class Main {
    private static final String INPUT_FILE_PATH =
            "src/com/Lab2/Part2/input.txt";   // Путь входного файла
    private static final String OUTPUT_FILE_NAME =
            "output.txt"; // Имя выходного файла
    private static final String OUTPUT_FILE_PATH =
            "src/com/Lab2/Part2/" + OUTPUT_FILE_NAME; // Путь выходного файла

    public static void main(String[] args) {
        // Чтение студентов из файла
        ArrayList<Student> students = ProcessStudents.readStudentsFromFile(INPUT_FILE_PATH);

        if (students.isEmpty()) {
            System.out.println("Файл пуст или не содержит корректных данных.");
            return;
        }

        // Отображение всех студентов
        System.out.println("Список студентов:");
        ProcessStudents.displayStudents(students);

        // Нахождение двух самых высоких студентов
        List<Student> topTwo = ProcessStudents.findTopTwoStudents(students);

        // Отображение результатов
        System.out.println("\nДва самых высоких студента:");
        ProcessStudents.displayStudents(topTwo);

        // Запись результатов в файл
        ProcessStudents.writeTopTwoToFile(OUTPUT_FILE_NAME, topTwo);
    }
}

