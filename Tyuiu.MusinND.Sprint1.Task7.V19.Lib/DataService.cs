﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MusinND.Sprint1.Task7.V19.Lib
{
    public class DataService : ISprint1Task7V19
    {
        public double Calculate(double x)
        {
            double z = Math.Round(x - ((7 * Math.Pow(x, 2)) / Math.Pow(x, 3)) + Math.Sin(x) + Math.Abs(Math.Pow(x, 4) - Math.Pow(x, 5)), 3);
            return z;
        }
    }
}
