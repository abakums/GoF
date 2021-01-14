using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4_Singleton.Factory.CarFactory;

namespace Lab4_Singleton.Factory
{
    class Client
    {
        private readonly AbstractBody b;
        private readonly AbstractCar c;
        private readonly AbstractEngine e;

        public Client(CarsFactory carFactory)
        {
            c = carFactory.CreateCar();
            e = carFactory.CreateEngine();
            b = carFactory.CreateBody();
        }

        public int GetMaxSpeed()
        {
            return c.MaxSpeed(e);
        }

        public string GetBodyType()
        {
            return c.BodyType(b);
        }

        public override string ToString()
        {
            return c.ToString();
        }
    }
}
