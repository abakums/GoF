using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Adapter.Climate
{
    class AdapterSensor : ISensor
    {
        private readonly FSensor sensor;
        public AdapterSensor(FSensor s)
        {
            sensor = s;
        }
        public double Determine()
        {
            return Math.Round(9 / 5 * (sensor.Determine() - 32), 1, MidpointRounding.ToEven);
        }
    }
}
