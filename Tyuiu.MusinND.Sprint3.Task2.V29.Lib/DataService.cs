using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MusinND.Sprint3.Task2.V29.Lib
{
    public class DataService : ISprint3Task2V29
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;

            int k = startValue;

            do
            {
                sum += (Math.Pow(value, k) + 0.25) * Math.Cos(k);
                k++;
            } while (k <= stopValue); 

            return Math.Round(sum, 3);
        }
    }
}
