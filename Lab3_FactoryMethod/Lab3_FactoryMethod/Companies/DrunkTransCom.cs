using Lab3_FactoryMethod.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_FactoryMethod.Companies
{
    class DrunkTransCom : TransportCompany
    {
        public DrunkTransCom(string name) :
        base(name)
        { }
        public override TransportService Create(string n, int t)
        {
            return new DrunkDriverServices(Name, t);
        }
    }
}
