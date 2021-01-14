using Lab4_Singleton.Factory.CarFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Singleton.Factory.AudiFactory
{
    class AudiFactory : CarsFactory
    {
        private static readonly Lazy<AudiFactory> audiFactory = new Lazy<AudiFactory>(() => new AudiFactory());
        public static AudiFactory GetAudiFactory => audiFactory.Value;
        public static AudiFactory Factory => audiFactory.Value;
        public override AbstractEngine CreateEngine() => new AudiEngine();
        public override AbstractCar CreateCar() => new AudiCar("Audi");
        public override AbstractBody CreateBody() => new AudiBody();
    }
}
