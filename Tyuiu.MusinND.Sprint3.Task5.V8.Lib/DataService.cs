using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MusinND.Sprint3.Task5.V8.Lib
{
    public class DataService : ISprint3Task5V8
    {
        public double GetSumSumSeries(int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double totalSum = 0;

            // Считаем внутреннюю сумму
            for (int k = startValue2; k <= stopValue2; k++)
            {
                totalSum += 1 / Math.Sin(k); // Суммируем 1/sin(k)
            }

            // Умножаем сумму на 3 и добавляем 3
            totalSum = totalSum * (stopValue1 - startValue1 + 1) + 3; // Умножаем на количество итераций по i (3)

            return totalSum; // Возвращаем результат
        }
    }
}
