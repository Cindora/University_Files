package com.Lab1.Abstract;

/**
 * Подкласс Персональный компьютер, наследуемый от класса Компьютер.
 * Доп. поле: userName
 */
public class APersonal extends AComputer {
    String userName;

    public APersonal(String modelName, String processor,
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
