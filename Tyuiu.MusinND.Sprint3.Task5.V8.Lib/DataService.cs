﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MusinND.Sprint3.Task5.V8.Lib
{
    public class DataService : ISprint3Task5V8
    {
        public double GetSumSumSeries(int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double totalSum = 0; // Переменная для хранения общей суммы

            // Внешний цикл для i от 1 до 3
            for (int i = startValue1; i <= stopValue1; i++)
            {
                // Внутренний цикл для k от 1 до 12
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    // Проверяем, чтобы избежать деления на ноль
                    if (Math.Sin(k) == 0)
                    {
                        continue; // Пропускаем k, если синус равен нулю
                    }

                    totalSum += 1 / Math.Sin(k); // Суммируем 1/sin(k)
                }
            }

            // Возвращаем общую сумму и добавляем 3
            return Math.Round((totalSum + 3),3);
        }
    }
}
