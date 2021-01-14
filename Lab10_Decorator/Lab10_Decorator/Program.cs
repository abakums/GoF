using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Renault reno1 = new Renault("Рено", "Renault LOGAN Active", 499.0);
            Print(reno1);
            AutoBase reno2 = new MediaNAV(reno1, "Навигация");
            Print(reno2);
            AutoBase reno3 = new SystemSecurity(new MediaNAV(reno1, "Навигация"),
            "Безопасность");
            Print(reno3);

            Audi audi1 = new Audi("Ауди", "Audi A4", 2000);
            Print(audi1);
            AutoBase audi2 = new LeatherInterior(audi1, "Комфорт");
            Print(audi2);
            AutoBase audi3 = new SteelWheels(new LeatherInterior(audi1, "Комфорт"), "Колеса");
            Print(audi3);

            Console.ReadKey();
        }
        private static void Print(AutoBase av)
        {
            Console.WriteLine(av.ToString());
        }
    }
}
