using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Strategy.Navigator
{
    class NavigatorContext
    {
        readonly StrategyNavigator strategy;
        readonly string start;
        readonly string finish;
        public string Place { get; }
        public NavigatorContext(StrategyNavigator strategy, string start, string finish)
        {
            this.strategy = strategy;
            this.start = start;
            this.finish = finish;
        }
        public void Go()
        {
            strategy.Go(start, finish);
        }
        public void ShowMap()
        {
            Console.WriteLine("Вы сейчас находитесь здесь: {0}", Place);
        }
        public void FindPlace(string p)
        {
            Console.WriteLine("Это место находится здесь: {0}", p);
        }
    }
}
