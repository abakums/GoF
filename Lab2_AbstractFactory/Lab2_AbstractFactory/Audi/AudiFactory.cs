using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_AbstractFactory.Audi
{
    class AudiFactory : CarFactory
    {
        public override AbstractCar CreateCar()
        {
            return new AudiCar("Ауди");
        }
        public override AbstractEngine CreateEngine()
        {
            return new AudiEngine();
        }
        public override AbstractBody CreateBody()
        {
            return new AudiBody("Универсал");
        }
    }
}
