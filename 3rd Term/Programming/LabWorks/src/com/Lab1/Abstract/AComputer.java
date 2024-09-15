package com.Lab1.Abstract;

/**
 * Абстрактный класс Компьютер.
 */
public abstract class AComputer implements iComputer {
    String modelName;
    String processor;
    String operatingSystem;
    int serialNumber;

    // Конструктор
    public AComputer(String modelName, String processor,
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
    public abstract void displayType() ;

    // Вывести информацию о компьютере
    public void displayInfo() {
        displayType();
        System.out.println("Модель: " + modelName +
                ", Процессор: " + processor +
                ", Операционная система: " + operatingSystem +
                ", Серийный номер: " + serialNumber);
    }
}
