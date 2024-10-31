using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MusinND.Sprint3.Task5.V8.Lib
{
    public class DataService : ISprint3Task5V8
    {
        public double GetSumSumSeries(int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double totalSum = 0;

            // Внешний цикл для i от 1 до 3
            for (int i = startValue1; i <= stopValue1; i++)
            {
                double innerSum = 0;

                // Внутренний цикл для k от 1 до 12
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    if (Math.Sin(k) != 0)
                    {
                        innerSum += 1 / Math.Sin(k); // Суммируем 1/sin(k) для каждого k
                    }
                }

                totalSum += innerSum; // Добавляем результат внутренней суммы в общую сумму
            }

            // Добавляем 3 к общей сумме после всех итераций внешнего цикла
            return totalSum + 3;
        }
    }
}
