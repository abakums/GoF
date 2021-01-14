using Lab6_TemplateMethod.CakeBake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 2;
            int l = 200;
            int h = 3;
            Progression val1 = new ArithmeticProgression(f, l, h);
            val1.TemplateMethod();

            Console.WriteLine();
            Progression val2 = new GeometricProgression(f, l, h);
            val2.TemplateMethod();

            Console.WriteLine();
            string s1 = "большой";
            int w1 = 1500;
            string f1 = "круглый";
            BakeCake cake1 = new CreamyCream(s1, f1, w1);
            cake1.TemplateMethod();

            Console.WriteLine();
            string s2 = "маленький";
            int w2 = 500;
            string f2 = "квадратный";
            BakeCake cake2 = new ProteinCream(s2, f2, w2);
            cake2.TemplateMethod();

            Console.ReadKey();
        }
    }
}
