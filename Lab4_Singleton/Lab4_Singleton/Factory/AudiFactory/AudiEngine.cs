using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Singleton.Factory.CarFactory
{
    class AudiEngine : AbstractEngine
    {
        public AudiEngine() => MaxSpeed = 250;
    }
}
