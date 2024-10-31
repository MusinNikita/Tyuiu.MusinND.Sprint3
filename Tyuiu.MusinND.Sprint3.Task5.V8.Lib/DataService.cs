using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MusinND.Sprint3.Task5.V8.Lib
{
    public class DataService : ISprint3Task5V8
    {
        public double GetSumSumSeries(int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double innerSum = 0;

            // Внутренний цикл для k от 1 до 12
            for (int k = startValue2; k <= stopValue2; k++)
            {
                if (Math.Sin(k) == 0)
                {
                    continue; // Пропускаем k, если sin(k) равен нулю
                }

                innerSum += 1 / Math.Sin(k); // Суммируем 1/sin(k)
            }

            // Умножаем внутреннюю сумму на количество итераций внешнего цикла (3)
            double totalSum = innerSum * (stopValue1 - startValue1 + 1);

            // Добавляем 3 после умножения
            return totalSum + 3;
        }
    }
}
