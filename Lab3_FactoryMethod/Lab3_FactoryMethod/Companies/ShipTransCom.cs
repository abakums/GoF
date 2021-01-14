using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_FactoryMethod.Companies
{
    class ShipTransCom : TransportCompany
    {
        public ShipTransCom(string name): 
        base(name)
        { }
        public override TransportService Create(string n, int t)
        {
            return new Shipping(Name, t);
        }
    }
}
