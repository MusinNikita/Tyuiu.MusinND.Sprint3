using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MusinND.Sprint3.Task5.V8.Lib
{
    public class DataService : ISprint3Task5V8
    {
        public double GetSumSumSeries(int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            // Внутренняя сумма по k от startValue2 до stopValue2
            for (int k = startValue2; k <= stopValue2; k++)
            {
                double totalSum = 0;

                // Внешний цикл от 1 до 3
                for (int i = 1; i <= 3; i++)
                {
                    // Внутренний цикл от 1 до 12
                    for (int k = 1; k <= 12; k++)
                    {
                        // Добавляем 1/sin(k) к общей сумме
                        totalSum += 1 / Math.Sin(k);
                    }
                }

                // Добавляем 3 к общей сумме
                totalSum += 3;

                return totalSum;
            }
    }
}
