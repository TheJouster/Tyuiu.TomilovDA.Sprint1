﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TomilovDA.Sprint1.Task5.V3.Lib
{
    public class DataService : ISprint1Task5V3
    {
        public int Calculate(int k)
        {
            int h = k % 1000;
            h /= 100;

            return h;
        }
    }
}
