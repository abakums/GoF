using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            double result = calculator.Add(5);
            Console.WriteLine(result);
            result = calculator.Sub(4);
            Console.WriteLine(result);
            result = calculator.Add(3);
            Console.WriteLine(result);
            result = calculator.Mul(4);
            Console.WriteLine(result);
            result = calculator.Div(4);
            Console.WriteLine(result);
            result = calculator.Undo(2);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
