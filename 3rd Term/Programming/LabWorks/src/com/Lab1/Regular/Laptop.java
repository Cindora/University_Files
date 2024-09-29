package com.Lab1.Regular;

/**
 * Подкласс Ноутбук, наследуемый от класса Компьютер.
 * Доп. поле: assemblyDate
 */
public class Laptop extends Computers {
    String assemblyDate;

    public String getAssemblyDate() {
        return assemblyDate;
    }

    public void setAssemblyDate(String assemblyDate) {
        this.assemblyDate = assemblyDate;
    }

    public Laptop(String modelName, String processor,
                  String operatingSystem, int serialNumber,
                  String assemblyDate) {
        super(modelName, processor, operatingSystem, serialNumber);
        this.assemblyDate = assemblyDate;
        type = "Laptop";
    }

    public void displayAssemblyDate() {
        System.out.println("Дата выпуска: " + assemblyDate);
    }

    @Override
    public void displayType() {
        System.out.println("Это ноутбук.");
    }
}