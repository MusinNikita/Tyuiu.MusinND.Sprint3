using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MusinND.Sprint3.Task5.V8.Lib
{
    public class DataService : ISprint3Task5V8
    {
        public double GetSumSumSeries(int startValue1 = 1, int startValue2 = 1, int stopValue1 = 3, int stopValue2 = 12)
        {
            double innerSum = 0;

            // Вычисляем внутреннюю сумму от k = 1 до 12
            for (int k = startValue2; k <= stopValue2; k++)
            {
                innerSum += 1 / Math.Sin(k); // Суммируем 1/sin(k)
            }

            // Умножаем внутреннюю сумму на количество итераций по i (3)
            double totalSum = (innerSum * (stopValue1 - startValue1 + 1)) + 3;

            return totalSum; // Возвращаем результат
        }
    }
}