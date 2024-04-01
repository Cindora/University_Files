package com.Lab2pt2;

import java.util.Scanner;

public class BranchingAlgorithm {
    /**
     * Алгоритм, вычисляющий значение выражения по четырём входящим параметрам.
     */
    public static double solveEquation(double x1, double x2, double x3, double x4) {
        double result;

        double a = x1;
        if (x2 > a) { a = x2; }
        if (x3 > a) { a = x3; }
        if (x4 > a) { a = x4; }

        double b = x1 + x2;
        if (x3 < b) { b = x3; }
        if (x4 < b) { b = x4; }

        result = (b-1)/(4*a+3);
        return result;
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        System.out.println("Enter x1, x2, x3, x4: ");
        double  x1 = in.nextDouble(),
                x2 = in.nextDouble(),
                x3 = in.nextDouble(),
                x4 = in.nextDouble();

        double answer = solveEquation(x1, x2, x3, x4);
        System.out.println("Answer: " + answer);
    }
}