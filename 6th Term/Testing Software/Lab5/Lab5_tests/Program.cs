using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_tests
{
    public class BonusCalculator
    {
        public int CalculateBonus(decimal sum, int count, string status)
        {
            if (sum < 0 || sum > 50000)
                throw new ArgumentException("Сумма вне пределов");
            if (count < 0 || count > 10)
                throw new ArgumentException("Количество покупок вне пределов");
            if (status != "обычный" && status != "постоянный")
                throw new ArgumentException("Неверный статус клиента");

            decimal percent = (status == "обычный") ? 0.01m : 0.03m;
            return (int)(sum * percent); // приведение к целому
        }
    }

    public class ArrayFilter
    {
        public int[] FilterArray(int[] A, int[] B)
        {
            if (A == null || B == null)
                return new int[0];

            var result = new List<int>();
            var bSet = new HashSet<int>(B);

            foreach (int x in A)
            {
                if (x > 0 && x % 2 == 0 && !bSet.Contains(x))
                    result.Add(x);
            }
            return result.ToArray();
        }
    }
}
