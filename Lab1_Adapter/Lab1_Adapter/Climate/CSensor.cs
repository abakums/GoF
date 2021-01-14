using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Adapter.Climate
{
    class CSensor : ISensor
    {
        //класс сенсора температуры в градусах Цельсия
        private readonly Random r;
        public CSensor()
        {
            r = new Random();
        }
        public double Determine()
        {
            return Math.Round(r.NextDouble() * 100, 1, MidpointRounding.ToEven);
        }
    }
}
