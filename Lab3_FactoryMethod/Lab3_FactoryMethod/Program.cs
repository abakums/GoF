using Lab3_FactoryMethod.Companies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            TransportCompany trCom = new TaxiTransCom("Служба такси");
            TransportService compService = trCom.Create("Такси", 1);
            double dist = 15.5;
            Print(compService, dist);

            TransportCompany gCom = new ShipTransCom("Служба перевозок");
            compService = gCom.Create("Грузоперевозки", 2);
            double distg = 150.5;
            Print(compService, distg);

            TransportCompany dCom = new DrunkTransCom("Служба пьяный водитель");
            compService = dCom.Create("Пьяный водитель", 4);
            double t = 2.5;
            Print(compService, t);

            Console.ReadKey();
        }
        private static void Print(TransportService compTax, double distg)
        {
            Console.WriteLine("Компания {0}, время {1} ч., стоимость: {2}",
            compTax.ToString(), distg, compTax.CostTransportation(distg));
        }
    }
}
