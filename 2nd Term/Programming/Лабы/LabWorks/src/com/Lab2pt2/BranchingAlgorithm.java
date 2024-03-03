package com.Lab2pt2;

import static java.lang.Math.*;

public class BranchingAlgorithm {
    /**
     * Алгоритм, вычисляющий значение выражения по четырём входящим параметрам.
     */
    public static double solveEquation(double x1, double x2, double x3, double x4) {
        double result;

        double a = max(max(x1, x2), max(x3, x4));
        double b = min(min(x1+x2, x3), x4);

        result = (b-1)/(4*a+3);
        return result;
    }

    public static void main(String[] args) {
        double  x1 = 1,
                x2 = -2,
                x3 = -6,
                x4 = -13;

        double answer = solveEquation(x1, x2, x3, x4);
        System.out.println("Answer: " + answer);
    }
}