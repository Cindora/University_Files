package com.Lab2pt1;

import static java.lang.Math.*;

public class BranchingAlgorithms {
    /**
     * Вычислительный алгоритм, осованный на ветвлении при помощи оператора if.
     */
    public static double ifAlgotithm(int a) {
        double result;

        if ((-1111 < a && a <= 11) || (15<= a && a <= 20)) {
            result = pow(a,2);
        } else if ((a == 114) || (a ==127) || (145 <= a && a<= 170) || (180 <= a && a<= 190)) {
            result = sin(a);
        } else if ((200 <= a && a <= 280) || (a==284) || (290<= a && a <= 1000)) {
            result = log10(a);
        } else {
            result = a+2;
        }
        return result;
    }
    /**
     * Вычислительный алгоритм, осованный на ветвлении при помощи оператора switch.
     */
    public static double switchAlgotithm(int a) {
        double result;

        switch (a) {
            case 15: case 16: case 17: case 18: case 19: case 20:
                result = Math.pow(a, 2);
                break;

            case 114: case 127: case 145: case 170: case 180: case 190:
                result = Math.sin(a);
                break;

            case 284:case 200: case 280: case 290: case 1000:
                result = Math.log10(a);
                break;

            default:
                if (-1111 < a && a <= 11) {
                    result = Math.pow(a, 2);
                } else {
                    result = a + 2;
                }
                break;
        }
        return result;
    }

    public static void main(String[] args) {
        int a = 1;

        double ifResult = ifAlgotithm(a);
        double switchResult = switchAlgotithm(a);

        System.out.println("Answer for if-algorithm: " + ifResult);
        System.out.println("Answer for switch-algorithm: " + switchResult);
    }
}
