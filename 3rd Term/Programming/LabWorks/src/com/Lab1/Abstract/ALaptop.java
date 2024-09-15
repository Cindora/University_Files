package com.Lab1.Abstract;

/**
 * Подкласс Ноутбук, наследуемый от класса Компьютер.
 * Доп. поле: assemblyDate
 */
public class ALaptop extends AComputer {
    String assemblyDate;

    public ALaptop(String modelName, String processor,
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
