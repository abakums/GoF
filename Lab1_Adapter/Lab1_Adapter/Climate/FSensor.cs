using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Adapter.Climate
{
    class FSensor : ISensor
    {
        //класс сенсора температуры в градусах Цельсия
        private readonly Random r;
        public FSensor()
        {
            r = new Random();
        }
        public double Determine()
        {
            return Math.Round(r.NextDouble() * 50, 1, MidpointRounding.ToEven);
        }
    }
}
