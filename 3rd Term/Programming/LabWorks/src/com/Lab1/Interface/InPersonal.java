package com.Lab1.Interface;

/**
 * Подкласс Персональный компьютер, наследуемый от класса Компьютер.
 * Доп. поле: userName
 */
public class InPersonal extends InComputer {
    String userName;

    public String getUserName() {
        return userName;
    }

    public void setUserName(String userName) {
        this.userName = userName;
    }

    public InPersonal(String modelName, String processor,
                      String operatingSystem, int serialNumber,
                      String userName) {
        super(modelName, processor, operatingSystem, serialNumber);
        this.userName = userName;
    }

    public void displayUserName() {
        System.out.println("Пользователь ПК: " + userName);
    }
}
