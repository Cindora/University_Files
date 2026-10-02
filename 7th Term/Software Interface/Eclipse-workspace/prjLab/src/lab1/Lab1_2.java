package lab1;

import java.util.Arrays;
import java.util.Random;
import java.util.Scanner;

public class Lab1_2 {

	public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Random rnd = new Random();

        /* 
    	 * 1. Дан одномерный массив Xn. 
    	 * Найти количество положительных чисел с дробной частью.
    	 */
        System.out.print("Задача 1. Введите размер массива X: ");
        int n = sc.nextInt();
        double[] x = new double[n];

        System.out.println("Введите элементы массива X через Enter:");
        for (int i = 0; i < n; i++) {
            System.out.print("x[" + i + "] = ");
            x[i] = sc.nextDouble();
        }

        int taskOneResult = taskOne(x);
        System.out.println("Количество положительных элементов с дробной частью: " + taskOneResult);

        /* 
    	 * 2. Дан одномерный массив Zm. 
    	 * Сформировать массив Yn, состоящий из нечетных значений элементов массива Zm.
    	 */
        System.out.print("\nЗадача 2. Введите размер массива Z: ");
        int m = sc.nextInt();

        int[] z = new int[m];
        int left = -20, right = 21; // [-20; 20]
        for (int i = 0; i < m; i++) {
            z[i] = rnd.nextInt(right - left) + left;
        }

        int[] y = taskTwo(z);
        System.out.println("Массив Z: " + Arrays.toString(z));
        System.out.println("Массив Y нечётных элементов: " + Arrays.toString(y));

        sc.close();
    }	
	
	public static int taskOne(double[] x) {
        int count = 0;
        for (double v : x) {
            if (v > 0 && v != Math.floor(v)) {   // Положительное число, имеет дробную часть
                count++;
            }
        }
        return count;
    }
	
	
    public static int[] taskTwo(int[] z) {
        int count = 0;
        for (int v : z) {
            if (v % 2 != 0) count++; // Подсчёт количества нечётных
        }
        
        int[] y = new int[count];
        int idx = 0;
        for (int v : z) {
            if (v % 2 != 0) {
                y[idx++] = v;
            }
        }
        return y;
    }

}
