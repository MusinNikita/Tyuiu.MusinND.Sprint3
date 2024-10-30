using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MusinND.Sprint3.Task5.V8.Lib
{
    public class DataService : ISprint3Task5V8
    {
        public double GetSumSumSeries(int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double totalSum = 0; // Переменная для хранения общей суммы

            // Внутренний цикл для k от 1 до 12
            for (int k = startValue2; k <= stopValue2; k++)
            {
                // Проверяем, чтобы избежать деления на ноль
                if (Math.Sin(k) == 0)
                {
                    continue; // Пропускаем k, если синус равен нулю
                }

                totalSum += 1 / Math.Sin(k); // Суммируем 1/sin(k)
            }

            // Умножаем на количество итераций внешнего цикла (в данном случае 3)
            totalSum *= (stopValue1 - startValue1 + 1); // Это 3, т.к. 3 - 1 + 1 = 3

            //Прибавляем + 3
            double finalySum = totalSum + 3;

            // Возвращаем общую сумму и добавляем 3
            return Math.Round(finalySum, 3);
        }
    }
}
