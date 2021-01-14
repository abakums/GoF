using Lab4_Singleton.Factory.CarFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Singleton.Factory.FordFactory
{
    class FordFactory : CarsFactory
    {
        private FordFactory()
        {
        }
        public override AbstractCar CreateCar() => new FordCar("Ford");
        public override AbstractEngine CreateEngine() => new FordEngine();
        public override AbstractBody CreateBody() => new FordBody();
    }
}
