using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_AbstractFactory
{
    class FordBody : AbstractBody
    {
        public FordBody(string type)
        {
            BodyType = type;
        }
        public override string ToString()
        {
            return "Тип кузова " + BodyType;
        }
    }
}
