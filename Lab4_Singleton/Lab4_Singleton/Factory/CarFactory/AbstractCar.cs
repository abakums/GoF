using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Singleton.Factory.CarFactory
{
    abstract class AbstractCar
    {
        public string Name { get; set; }
        public abstract int MaxSpeed(AbstractEngine engine);
        public string BodyType(AbstractBody body) => body.BodyType;
    }
}
