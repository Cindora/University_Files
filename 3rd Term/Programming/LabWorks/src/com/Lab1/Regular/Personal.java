package com.Lab1.Regular;

/**
 * Подкласс Персональный компьютер, наследуемый от класса Компьютер.
 * Доп. поле: userName
 */
public class Personal extends Computers {
    String userName;

    public String getUserName() {
        return userName;
    }

    public void setUserName(String userName) {
        this.userName = userName;
    }

    public Personal(String modelName, String processor,
                    String operatingSystem, int serialNumber,
                    String userName) {
        super(modelName, processor, operatingSystem, serialNumber);
        this.userName = userName;
        type = "Personal";
    }

    public void displayUserName() {
        System.out.println("Пользователь ПК: " + userName);
    }

    @Override
    public void displayType() {
        System.out.println("Это персональный компьютер.");
    }
}
