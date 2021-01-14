using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Strategy
{
    abstract class StrategySort
    {
        public string Title { get; set; }
        public abstract void Sort(int[] array);
    }
}
