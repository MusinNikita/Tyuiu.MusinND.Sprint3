using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MusinND.Sprint3.Task4.V17.Lib
{
    public class DataService : ISprint3Task4V17
    {
        public double Calculate(int startValue, int stopValue)
        {
            double product = 1; // Инициализация переменной для хранения произведения

            // Проходим по всем значениям от startValue до stopValue
            for (int x = startValue; x <= stopValue; x++)
            {
                // Проверяем, не равно ли x нулю
                if (x == 0)
                {
                    break; // Прерываем цикл, если x равен 0
                }

                // Вычисляем значение функции y = cos(x) / sin(x)
                double y = Math.Cos(x) / Math.Sin(x);

                // Умножаем результат на текущее произведение
                product *= y;
            }

            return product; // Возвращаем итоговое произведение
        }
    }
}
