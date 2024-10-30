﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MusinND.Sprint3.Task0.V11.Lib
{
    public double GetSumSeries(int value, int startValue, int stopValue)
    {
        double sum = 0;

        for (int k = startValue; k <= stopValue; k++)
        {
            sum += Math.Pow(1.0 / (value * k), 2);
        }

        return sum;
    }
}
