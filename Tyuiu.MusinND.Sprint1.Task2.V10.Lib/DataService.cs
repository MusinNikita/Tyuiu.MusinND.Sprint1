﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MusinND.Sprint1.Task2.V10.Lib
{
    public class DataService : ISprint1Task2V10
    {
        public double ConvertMetreToInchs(int value)
        {
            double inches = 39.37;
            double metreToInchs = Math.Round(value * inches, 2);
            return metreToInchs;
        }
    }
}
