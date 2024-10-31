using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MusinND.Sprint3.Task5.V8.Lib
{
    public class DataService : ISprint3Task5V8
    {
        public double GetSumSumSeries(int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double result = 0;

            // Внутренняя сумма по k от 1 до 12
            for (int k = 1; k <= 12; k++)
            {
                // Переводим k в радианы, так как Math.Sin работает с радианами
                double radians = k * Math.PI / 180;
                result += 1 / Math.Sin(radians);
            }

            // Внешняя сумма умножает внутреннюю на 3, затем добавляем 3
            result = result + 3;
            return result;
        }
    }
}
