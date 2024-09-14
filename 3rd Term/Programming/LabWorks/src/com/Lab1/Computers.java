package com.Lab1;

/**
 * Базовый класс Компьютер.
 */
public class Computers {
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
        System.out.println("Модель: " + modelName +
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
    }

    public void displayUserName() {
        System.out.println("Пользователь ПК: " + userName);
    }

    @Override
    public void displayType() {
        System.out.println("Это персональный компьютер.");
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
    }

    public void displayAssemblyDate() {
        System.out.println("Дата выпуска: " + assemblyDate);
    }

    @Override
    public void displayType() {
        System.out.println("Это компьютер типа ноутбук.");
    }
}