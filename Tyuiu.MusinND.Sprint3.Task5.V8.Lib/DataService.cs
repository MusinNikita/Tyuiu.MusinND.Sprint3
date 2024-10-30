using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MusinND.Sprint3.Task5.V8.Lib
{
    public class DataService : ISprint3Task5V8
    {
        public double GetSumSumSeries(int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double innerSum = 0; // Переменная для внутренней суммы

            // Внутренний цикл для k от 1 до 12
            for (int k = startValue2; k <= stopValue2; k++)
            {
                innerSum += Math.Sin(k); // Суммируем sin(k)
            }

            double outerSum = 0; // Переменная для внешней суммы

            // Внешний цикл для i от 1 до 3
            for (int i = startValue1; i <= stopValue1; i++)
            {
                outerSum += innerSum; // Добавляем внутреннюю сумму к внешней
            }

            // Возвращаем результат с добавлением 3
            return Math.Round((outerSum + 3),3);
        }
    }
}
