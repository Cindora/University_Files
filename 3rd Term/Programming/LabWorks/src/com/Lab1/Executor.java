package com.Lab1;

/**
 * Класс с функциональностью над классом Компьютер
 */
public class Executor {

    /**
     * Вывести инфо о компьютерах с данным процессором
     * @param processorType Процессор
     */
    public static void displayByProcessor(Computers[] computers, String processorType) {
        System.out.println("Компьютеры с процессором: " + processorType);
        for (Computers comp : computers) {
            if (comp != null)
                if (comp.processor.equals(processorType)) {
                    comp.displayInfo();
                }
        }
    }

    /**
     * Метод подсчёта числа компьютеров с ОС Windows
     */
    public static void countWindowsComputers(Computers[] computers) {
        int count = 0;
        for (Computers comp : computers) {
            if (comp != null)
                if (comp.getOperatingSystem().equals("Windows")) {
                    count++;
                }
        }
        System.out.println("Количество компьютеров с ОС Windows: " + count);
    }
}
