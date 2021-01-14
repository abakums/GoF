using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Adapter.Climate
{
    class ClimateSystem
    {
        public string Name { get; set; }
        public ClimateSystem(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
        public double Run(ISensor temperatureSensor)
        {
            return temperatureSensor.Determine();
        }
    }
}
