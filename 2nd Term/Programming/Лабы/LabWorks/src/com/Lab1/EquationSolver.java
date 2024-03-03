package com.Lab1;

import static java.lang.Math.*;

public class EquationSolver {
    /**
     * Алгоритм, вычисляющий значение выражения по трём входящим параметрам.
     */
    public static double solveEquation(double a, double b, double c) {
        double result;
        result = a * sqrt(cos(a) + a) +
                pow(c, 1.3) / (cos(pow(a, 3.2)) - a/3) +
                (1 + sin(sqrt(pow(b, 1.7) + 1))) / (cos(12*c - 4));
        return result;
    }

    public static void main(String[] args) {
        double a = 1;
        double b = 0;
        double c = PI/3;

        double answer = solveEquation(a, b, c);
        System.out.println("Answer for a = 1, b = 0, c = Pi/3: " + answer);
    }
}
