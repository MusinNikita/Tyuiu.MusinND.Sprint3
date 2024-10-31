using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MusinND.Sprint3.Task5.V8.Lib
{
    public class DataService : ISprint3Task5V8
    {
        public double GetSumSumSeries(int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double totalSum = 0;

            // Внешний цикл от startValue1 до stopValue1
            for (int i = startValue1; i <= stopValue1; i++)
            {
                // Внутренний цикл от startValue2 до stopValue2
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    totalSum += Math.Sin(k); // Суммируем sin(k)
                }
            }

            // Добавляем 3 к итоговой сумме
            totalSum += 3;

            return totalSum; // Возвращаем результат
        }
    }
}
