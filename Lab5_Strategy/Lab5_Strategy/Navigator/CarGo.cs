using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Strategy.Navigator
{
    class CarGo : StrategyNavigator
    {
        public CarGo()
        {
            Type = "На машине";
        }
        public override string ToString()
        {
            return Type;
        }
        public override void Go(string start, string finish)
        {
            Console.WriteLine($"Вы отправляетесь {Type}. Необходимо проследовать от {start}, затем Вы прибудете в точку {finish}." +
                $"Путь будет быстрее, чем пешком в 8 раз. И быстрее чем на велосипеде в 2 раза.");
        }
    }
}
