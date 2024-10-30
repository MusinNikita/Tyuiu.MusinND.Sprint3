using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MusinND.Sprint3.Task5.V8.Lib
{
    public class DataService : ISprint3Task5V8
    {
        public double GetSumSumSeries(int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double totalSum = 0.0;

            // Внешний цикл для i от startValue1 до stopValue1 (от 1 до 12)
            for (int i = startValue1; i <= stopValue1; i++)
            {
                double innerSum = 0.0;

                // Внутренний цикл для k от startValue2 до stopValue2 (от 1 до 12)
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    innerSum += 1.0 / Math.Sin(k); // Рассчитываем внутреннюю сумму
                }

                totalSum += innerSum; // Добавляем внутреннюю сумму к общей сумме
            }

            // Добавляем 3 к итоговому результату
            return totalSum + 3;
        }
    }
}
