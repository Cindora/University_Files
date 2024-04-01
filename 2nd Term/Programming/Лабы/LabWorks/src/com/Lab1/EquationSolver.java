package com.Lab1;

import java.util.Scanner;

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

        Scanner in = new Scanner(System.in);
        double a = in.nextDouble();
        double b = in.nextDouble();
        double c = in.nextDouble();

        double answer = solveEquation(a, b, c);
        System.out.println("Answer: " + answer);
    }
}
