using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MusinND.Sprint3.Task1.V18.Lib
{
    public class DataService : ISprint3Task1V18
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                sum += Math.Sin(i);
            }

            sum *= Math.Pow(1.0 / 4.0, 2);

            return Math.Round(sum, 3);
        }
    }
}
