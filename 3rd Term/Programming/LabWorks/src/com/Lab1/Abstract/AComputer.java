package com.Lab1.Abstract;

/**
 * Абстрактный класс Компьютер.
 */
public abstract class AComputer {
    String modelName;
    String processor;
    String operatingSystem;
    int serialNumber;

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

    // Абстрактный метод (будет реализован в дочерних классах)
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
