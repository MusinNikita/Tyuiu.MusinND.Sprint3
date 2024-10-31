using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MusinND.Sprint3.Task6.V28.Lib
{
    public class DataService : ISprint3Task6V28
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalCount = 0;

            // Перебираем все числа в заданном диапазоне
            for (int num = startValue; num <= stopValue; num++)
            {
                // Считаем делители меньше 7
                for (int i = 1; i < 7; i++)
                {
                    if (num % i == 0)
                    {
                        totalCount++;
                    }
                }
            }

            return totalCount;
        }
    }
}
