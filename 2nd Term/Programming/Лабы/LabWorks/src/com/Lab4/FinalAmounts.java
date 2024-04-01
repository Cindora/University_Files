package com.Lab4;

import java.util.Scanner;

public class FinalAmounts {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Введите значение x: ");
        double x = scanner.nextDouble();

        System.out.print("Введите точность вычислений: ");
        double E = scanner.nextDouble();

        scanner.close();

        double R = (x-1) / (x+1);
        double sum = R;
        int k = 1;

        do {
            k=k+1;
            R = R * Math.pow((x-1) / (x+1), 2) * ((double) (2 * k - 3) / (2 * k - 1));
            sum = sum + R;
        } while(Math.abs(R/sum) > E && k < 1000);

        if (k < 1000){
            double sumByFunction = Math.log(x)/2;
            System.out.println("Значение суммы: " + sum +
                    "\nЗначение функции: " + sumByFunction +
                    "\nРазница между значениями: " + Math.abs(sum - sumByFunction) +
                    "\nВычисления закончены на шаге k = " + k);
        }
        else {
            System.out.println("Превышение лимита операций.");
        }
    }
}
