package com.Lab1.Interface;

/**
 * Подкласс Ноутбук, наследуемый от класса Компьютер.
 * Доп. поле: assemblyDate
 */
public class InLaptop extends InComputer {
    String assemblyDate;

    public String getAssemblyDate() {
        return assemblyDate;
    }

    public void setAssemblyDate(String assemblyDate) {
        this.assemblyDate = assemblyDate;
    }

    public InLaptop(String modelName, String processor,
                    String operatingSystem, int serialNumber,
                    String assemblyDate) {
        super(modelName, processor, operatingSystem, serialNumber);
        this.assemblyDate = assemblyDate;
    }

    public void displayAssemblyDate() {
        System.out.println("Дата выпуска: " + assemblyDate);
    }
}
