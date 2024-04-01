package com.Lab5;

import java.util.Scanner;

public class FunctionTabulating {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        double  A = in.nextDouble(),
                B = in.nextDouble();
        int     N = in.nextInt();
        in.close();

        findFuncMaximum(A, B, N);
    }

    private static void findFuncMaximum(double A, double B, int N) {
        double  F, Fmax = Double.NEGATIVE_INFINITY,
                x = A, Xmax = Double.NEGATIVE_INFINITY,
                H = (B - A) / (N - 1);
        while (x<=B + H/2) {
            F = Math.log(1/(2 + 2*x + x*x));
            if (F>Fmax) { Fmax = F; Xmax = x; }
            x += H;
        }

        System.out.printf("Максимум: x = %1.4f, F(x) = %1.4f.\n", Xmax, Fmax);
    }
}
