using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MusinND.Sprint3.Task0.V11.Lib
{
    public class DataService : ISprint3Task0V11
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sum = 0;

            for (int k = startValue; k <= stopValue; k++)
            {
                sum += Math.Pow(1.0 / Math.Pow(value, k), 2); // (1 / n^k)^2 = 1 / (n^(2k))
            }

            return sum;
        }
    }
}
