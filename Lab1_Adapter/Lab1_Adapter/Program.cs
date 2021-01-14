using System;
using Lab1_Adapter.Climate;

namespace Lab1_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Game
            //Kost kubik = new Kost();
            //Gamer g1 = new Gamer("Иван");
            //Console.WriteLine("Выпало очков {0} для игрока {1}",
            //g1.SeansGame(kubik), g1.ToString());
            //Monet mon = new Monet();
            //IGame bmon = new AdapterGame(mon);
            //Console.WriteLine("Монета показала \"{0}\" для игрока {1}", g1.SeansGame(bmon),
            //g1.ToString());

            // Climate
            ClimateSystem sys = new ClimateSystem("Control System");
            FSensor fSensor = new FSensor();
            ISensor sensorAdapter = new AdapterSensor(fSensor);
            Console.WriteLine("System: {0}. Celsium temperature {1}", sys.Name, sensorAdapter.Determine());
            Console.ReadKey();
        }
    }
}
