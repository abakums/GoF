using Lab4_Singleton.Factory;
using Lab4_Singleton.Factory.AudiFactory;
using Lab4_Singleton.Factory.CarFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Log lg = Log.MyLog;
            lg.LogExecution("Метод Main()");
            double op = Operation.Run('-', 35);
            op = Operation.Run('+', 30);

            CarsFactory audiFactory = AudiFactory.GetAudiFactory;
            Client client = new Client(audiFactory);
            Console.WriteLine("Максимальная скорость {0} - {1} км/ч", client, client.GetMaxSpeed());

            Console.ReadKey();
        }
    }
}
