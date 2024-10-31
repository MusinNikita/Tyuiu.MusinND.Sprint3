using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MusinND.Sprint3.Task7.V26.Lib
{
    public class DataService : ISprint3Task7V26
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            // Определяем размер массива
            int size = (stopValue - startValue) + 1;
            double[] results = new double[size];

            // Заполняем массив значениями функции
            for (int i = 0; i < size; i++)
            {
                double x = startValue + i; // вычисляем текущее значение x
                results[i] = CalculateF(x);
            }

            return results;
        }

        private double CalculateF(double x)
        {
            double denominator = 2 * x - 0.5;

            // Проверка деления на ноль
            if (denominator == 0)
            {
                return 0; // Возвращаем 0 при делении на ноль
            }

            // Вычисление значения функции
            return 5 - 3 * x + (1 + Math.Sin(x)) / denominator;
        }
    }
}
