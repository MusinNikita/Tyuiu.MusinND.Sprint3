using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MusinND.Sprint3.Task5.V8.Lib
{
    public class DataService : ISprint3Task5V8
    {
        public double GetSumSumSeries(int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double totalSum = 0;

            // Внутренний цикл от startValue2 до stopValue2 (1 до 12)
            for (int k = startValue2; k <= stopValue2; k++)
            {
                totalSum += Math.Sin(k); // Суммируем sin(k)
            }

            // Умножаем сумму на 3 и добавляем 3
            totalSum = 3 * totalSum + 3;

            return totalSum; // Возвращаем результат
        }
    }
}
