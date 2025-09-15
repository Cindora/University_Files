/*
 *  Дан одномерный массив Xn. Найти количество элементов массива, кратных 4. 
 *  Сформировать новый массив из квадратов отрицательных элементов массива Xn.
*/

internal class Program
{
    private static void Main(string[] args)
    {
        int[] Xn, Zn;
        int countXFour = 0, countNegative = 0, lenXn, lenZn;
        string[] inputArr;

        
        Console.Write("Введите длину массива: ");
        lenXn = Convert.ToInt32(Console.ReadLine());
        
        while (lenXn <= 0)
        {
            Console.Write("Введите корректуню длину массива: ");
            lenXn = Convert.ToInt32(Console.ReadLine());
        }
        
        Xn = new int[lenXn];

        Console.WriteLine("Введите элементы массива (" + lenXn + " шт.) через пробел: ");

        // Convert input to int array
        inputArr = Console.ReadLine().Split(" ");

        for (int i = 0; i<lenXn; i++)
        {
            Xn[i] = Convert.ToInt32(inputArr[i]);
            if (Xn[i] % 4 == 0) // the number of elements multiples of four
            {
                countXFour++;
            }
            if (Xn[i] < 0) // the number of elements less than zero
            {
                countNegative++;
            }
        }
        //

        Console.WriteLine();
        Console.WriteLine("Количество элементов кратных 4-м равно: " + countXFour);
        
        if (countXFour > 0)
        {
            // create an array of squares of negative numbers
            Zn = new int[countNegative];

            int j = 0;

            foreach(int el in Xn)
            {
                if (el < 0)
                {
                    Zn[j++] = el*el;
                }
            }
            //

            
            Console.Write("Массив квадратов отрицательных элементов: ");
            foreach(int el in Zn) // Output of Zn
            {
                Console.Write(el.ToString() + " ");
            }
        }
        else
        {
            Console.Write("В исходном массиве нет отрицательных элементов.");
        }
        Console.WriteLine();
    }
}