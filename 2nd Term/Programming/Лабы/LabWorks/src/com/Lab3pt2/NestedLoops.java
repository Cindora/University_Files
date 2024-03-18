package com.Lab3pt2;

import java.util.Scanner;

public class NestedLoops {
    /**
     * Алгоритм, вычисляющий значение выражения при помощи вложенных циклов по входящим параметрам.
     */
    public static double solveEquationFor(int N, int M, double c) {
        double result = 1;

        double sumResult;
        for (int i=0; i<=N; i++) {
            sumResult = 0;
            for (int j=0; j<= M; j++) {
                sumResult += c*i - j;
            }
            result *= c + i*i + sumResult;
        }

        return result;
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int M = in.nextInt(),
            N = in.nextInt();
        double c = in.nextDouble();

        double  answer = solveEquationFor(N, M, c);
        System.out.println("Answer: " + answer);
    }
}
