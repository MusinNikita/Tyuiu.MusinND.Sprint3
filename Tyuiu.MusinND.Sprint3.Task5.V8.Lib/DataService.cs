using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MusinND.Sprint3.Task5.V8.Lib
{
    public class DataService : ISprint3Task5V8
    {
        public double GetSumSumSeries(int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double innerSum = 0;

            // Внутренняя сумма по k от startValue2 до stopValue2
            for (int k = startValue2; k <= stopValue2; k++)
            {
                // Переводим k в радианы
                double radians = k * Math.PI / 180;
                // Проверяем, что синус не равен 0, чтобы избежать деления на 0
                if (Math.Sin(radians) != 0)
                {
                    innerSum += 1 / Math.Sin(radians);
                }
                else
                {
                    // Если синус равен 0, добавляем очень большое число (или можно просто пропустить)
                    innerSum += double.MaxValue; // или просто продолжить
                }
            }

            // Умножаем внутреннюю сумму на startValue1 (количество итераций)
            double result = startValue1 * innerSum + 3;

            return result;
        }
    }
}
