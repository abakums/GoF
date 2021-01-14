using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_AbstractFactory
{
    class FordFactory : CarFactory
    {
        public override AbstractCar CreateCar()
        {
            return new FordCar("Форд");
        }
        public override AbstractEngine CreateEngine()
        {
            return new FordEngine();
        }
        public override AbstractBody CreateBody()
        {
            return new FordBody("Седан");
        }
    }
}
