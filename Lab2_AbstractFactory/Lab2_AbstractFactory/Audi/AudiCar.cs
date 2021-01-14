using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_AbstractFactory.Audi
{
    class AudiCar : AbstractCar
    {
        public AudiCar(string name)
        {
            Name = name;
        }

        public override int MaxSpeed(AbstractEngine engine)
        {
            return engine.max_speed;
        }
        public override string ToString()
        {
            return "Автомобиль " + Name;
        }
    }
}
