using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MusinND.Sprint3.Task5.V8.Lib
{
    public class DataService : ISprint3Task5V8
    {
        public double GetSumSumSeries(int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double totalSum = 0.0;

            // Один цикл для k от startValue2 до stopValue2 (от 1 до 12)
            for (int k = startValue2; k <= stopValue2; k++)
            {
                totalSum += 1.0 / Math.Sin(k); // Рассчитываем сумму
            }

            // Умножаем на количество итераций внешнего цикла и добавляем 3
            return (totalSum * (stopValue1 - startValue1 + 1)) + 3;
        }

    }
}
}
