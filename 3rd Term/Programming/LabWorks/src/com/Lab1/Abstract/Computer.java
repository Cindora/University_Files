package com.Lab1.Abstract;

/**
 * Абстрактный класс Компьютер.
 */
abstract class Computer implements iComputer {
    String modelName;
    String processor;
    String operatingSystem;
    int serialNumber;

    // Конструктор
    public Computer(String modelName, String processor,
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

    // Абстрактный метод из интерфейса (будет реализован в дочерних классах)
    @Override
    public abstract void displayType();

    // Вывести информацию о компьютере
    public void displayInfo() {
        displayType();
        System.out.println("Модель: " + modelName +
                ", Процессор: " + processor +
                ", Операционная система: " + operatingSystem +
                ", Серийный номер: " + serialNumber);
    }
}

/**
 * Подкласс Персональный компьютер, наследуемый от класса Компьютер.
 * Доп. поле: userName
 */
class Personal extends Computer {
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

    // Реализация метода displayType из интерфейса
    @Override
    public void displayType() {
        System.out.println("Это персональный компьютер.");
    }
}

/**
 * Подкласс Ноутбук, наследуемый от класса Компьютер.
 * Доп. поле: assemblyDate
 */
class Laptop extends Computer {
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

    // Реализация метода displayType из интерфейса
    @Override
    public void displayType() {
        System.out.println("Это ноутбук.");
    }
}
