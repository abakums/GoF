using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Strategy.Navigator
{
    abstract class StrategyNavigator
    {
        public string Type { get; set; }
        public abstract void Go(string start, string finish);
    }
}
