using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Strategy.Navigator
{
    class FootGo : StrategyNavigator
    {
        public FootGo()
        {
            Type = "Пешком";
        }
        public override string ToString()
        {
            return Type;
        }
        public override void Go(string start, string finish)
        {
            Console.WriteLine($"Вы отправляетесь {Type}. Необходимо проследовать от {start}, затем Вы прибудете в точку {finish}." +
                $"Путь будет медленнее, чем на велосипеде в 4 раз, и медленнее, чем на машине в 8 раза.");
        }
    }
}
