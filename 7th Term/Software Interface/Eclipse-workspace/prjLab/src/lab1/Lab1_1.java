package lab1;

import java.util.Scanner;

public class Lab1_1 {
	
	// Вычислить минимальное значение из 3-х чисел
	// Ввод с клавиатуры
	
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);

	    System.out.print("Введите три числа через Enter: ");
	    double a = sc.nextInt();
	    double b = sc.nextInt();
	    double c = sc.nextInt();

	    double min = Math.min(a, Math.min(b, c));
	    System.out.println("Минимальное число: " + min);

        sc.close();
	}
}
