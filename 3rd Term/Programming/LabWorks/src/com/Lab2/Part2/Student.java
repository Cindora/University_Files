package com.Lab2.Part2;

public class Student {
    private final String surname;
    private final int height;

    public Student(String surname, int height) {
        this.surname = surname;
        this.height = height;
    }

    public String getSurname() {
        return surname;
    }

    public int getHeight() {
        return height;
    }

    public String getStudentInfo() {
        return String.format("%-20s | %-5d", surname, height);
    }
}

