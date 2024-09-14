package com.Lab1.Abstract;

public interface iComputer {
    String modelName = null;
    String processor = null;
    String operatingSystem = null;
    int serialNumber = -1;
    void displayType();  // Метод для отображения типа компьютера
    void displayInfo(); // Метод для отображения общей информации
}
