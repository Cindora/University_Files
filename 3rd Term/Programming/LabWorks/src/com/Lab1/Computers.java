package com.Lab1;

/**
 * Базовый класс Компьютер.
 */
public class Computers {
    String type;
    String modelName;
    String processor;
    String operatingSystem;
    int serialNumber;


    // Constructor
    public Computers(String modelName, String processor,
                     String operatingSystem, int serialNumber) {
        this.modelName = modelName;
        this.processor = processor;
        this.operatingSystem = operatingSystem;
        this.serialNumber = serialNumber;
        type = "-";
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

    // Вывести информацию о компьютере
    public void displayInfo() {
        System.out.println("Тип: " + type +
                ", Модель: " + modelName +
                ", Процессор: " + processor +
                ", Операционная система: " + operatingSystem +
                "Серийный номер: " + serialNumber);
    }
}

/**
 * Подкласс Персональный компьютер, наследуемый от класса Компьютер.
 * Доп. поле: userName
 */
class Personal extends Computers {
    String userName;
    public Personal(String modelName, String processor,
                    String operatingSystem, int serialNumber,
                    String userName) {
        super(modelName, processor, operatingSystem, serialNumber);
        this.userName = userName;
        type = "ПК";
    }
}

/**
 * Подкласс Ноутбук, наследуемый от класса Компьютер.
 * Доп. поле: assemblyDate
 */
class Laptop extends Computers {
    String assemblyDate;
    public Laptop(String modelName, String processor,
                  String operatingSystem, int serialNumber,
                  String assemblyDate) {
        super(modelName, processor, operatingSystem, serialNumber);
        this.assemblyDate = assemblyDate;
        type = "Ноутбук";
    }
}