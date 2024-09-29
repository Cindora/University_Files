package com.Lab1.Regular;

/**
 * Базовый класс Компьютер.
 */
public class Computers {
    String type;
    String modelName;
    String processor;
    String operatingSystem;
    int serialNumber;

    public String getType() {
        return type;
    }

    public void setType(String type) {
        this.type = type;
    }

    public void setModelName(String modelName) {
        this.modelName = modelName;
    }

    public void setProcessor(String processor) {
        this.processor = processor;
    }

    public void setOperatingSystem(String operatingSystem) {
        this.operatingSystem = operatingSystem;
    }

    public void setSerialNumber(int serialNumber) {
        this.serialNumber = serialNumber;
    }

    // Constructor
    public Computers(String modelName, String processor,
                     String operatingSystem, int serialNumber) {
        this.modelName = modelName;
        this.processor = processor;
        this.operatingSystem = operatingSystem;
        this.serialNumber = serialNumber;
        type = "Computer";
    }

    public String getModelName() {
        return modelName;
    }
    public String getProcessor() {
        return processor;
    }
    public String getOperatingSystem() {
        return operatingSystem;
    }
    public int getSerialNumber() {
        return serialNumber;
    }

    // Метод для переопределения в дочерних классах
    public void displayType() {
        System.out.println("Это общий тип компьютера.");
    }

    // Вывести информацию о компьютере
    public void displayInfo() {
        displayType();
        System.out.println("Модель: " + modelName +
                ", Процессор: " + processor +
                ", Операционная система: " + operatingSystem +
                ", Серийный номер: " + serialNumber);
    }
}

