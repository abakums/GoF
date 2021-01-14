using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_FactoryMethod.Services
{
    class DrunkDriverServices : TransportService
    {
        public double CarClass { get; set; }
        public DrunkDriverServices(string name, int cl) :
        base(name)
        {
            CarClass = cl;
        }
        public override double CostTransportation(double t)
        {
            return CarClass * t * 300;
        }
        public override string ToString()
        {
            string s = String.Format("Фирма {0}, услуга пьяный водитель по тарифу {1}",
            Name, CarClass);
            return s;
        }
    }
}
