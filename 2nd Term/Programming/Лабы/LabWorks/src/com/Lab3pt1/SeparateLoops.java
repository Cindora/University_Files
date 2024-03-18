package com.Lab3pt1;

import java.util.Scanner;

public class SeparateLoops {
    /**
     * Алгоритм, вычисляющий значение выражения при помощи вложенных циклов по входящим параметрам.
     */
    public static double solveEquationFor(int N, int M, double a) {
        double result = 0;

        for (int i = 1; i <= N; i++) {
            result += (i+a)/(2*i+1);
            result += (i+a)/(a*i);
        }

        double multResult = 1;
        for (int k = 1; k <= M; k++) {
            multResult *= (double) (2 * k) / (2+k);
        }
        result += multResult;

        return result;
    }

    public static double solveEquationWhile(int N, int M, double a) {
        double result = 0;

        int i = 1;
        while (i <= N) {
            result += (i+a)/(2*i+1);
            result += (i+a)/(a*i);
            i++;
        }

        int k = 1;
        double multResult = 1;
        while (k <= M) {
            multResult *= (double) (2 * k) / (2+k);
            k++;
        }
        result += multResult;

        return result;
    }

    public static double solveEquationDoWhile(int N, int M, double a) {
        double result = 0;

        if (N>=1) {
            int i = 1;
            do {
                result += (i+a)/(2*i+1);
                result += (i+a)/(a*i);
                i++;
            } while (i <= N);
        }

        if (M>=1) {
            int k = 1;
            double multResult = 1;
            do {
                multResult *= (double) (2 * k) / (2+k);
                k++;
            } while (k <= M);
            result += multResult;
        }
        return result;
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int N = in.nextInt(),
                M = in.nextInt();
        double a = in.nextDouble();

        double  answerFor = solveEquationFor(N, M, a),
                answerWhile = solveEquationWhile(N, M, a),
                answerDoWhile = solveEquationDoWhile(N, M, a);
        System.out.println("Answer (for): " + answerFor +
                "\nAnswer (while): " + answerWhile +
                "\nAnswer (do while): " + answerDoWhile);
    }
}
