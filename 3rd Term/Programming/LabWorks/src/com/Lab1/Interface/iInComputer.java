package com.Lab1.Interface;

public interface iInComputer {
    void displayInfo(); // Метод для отображения общей информации
    void setProcessor(String processor);
    void setOperatingSystem(String operatingSystem);
    void setSerialNumber(int serialNumber);

    String getModelName();
    String getProcessor();
    String getOperatingSystem();
    int getSerialNumber();
}
