using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_AbstractFactory
{
    class FordCar : AbstractCar
    {
        public FordCar(string name)
        {
            Name = name;
        }
        public override int MaxSpeed(AbstractEngine engine)
        {
            int ms = engine.max_speed;
            return ms;
        }
        public override string ToString()
        {
            return "Автомобиль " + Name;
        }
    }
}
