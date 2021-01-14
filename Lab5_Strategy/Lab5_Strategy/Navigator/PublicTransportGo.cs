using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Strategy.Navigator
{
    class PublicTransportGo : StrategyNavigator
    {
        public PublicTransportGo()
        {
            Type = "На общественном транспорте";
        }
        public override string ToString()
        {
            return Type;
        }
        public override void Go(string start, string finish)
        {
            Console.WriteLine($"Вы отправляетесь {Type}. Необходимо проследовать от {start}, затем Вы прибудете в точку {finish}." +
                $"Путь будет медленнее, чем на машине в 1,5 раза, но быстрее, чем пешком, в 6 раза.");
        }
    }
}
