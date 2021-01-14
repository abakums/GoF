using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Strategy.Navigator
{
    class SightseeingGo : StrategyNavigator
    {
        public SightseeingGo()
        {
            Type = "На просмотр достопримечательностей";
        }
        public override string ToString()
        {
            return Type;
        }
        public override void Go(string start, string finish)
        {
            Console.WriteLine($"Вы отправляетесь {Type}. Необходимо проследовать от {start}, затем Вы прибудете в точку {finish}." +
                $"Просмотр красивых мест важнее времени пути! Наслаждайтесь достопримечательностями.");
        }
    }
}
