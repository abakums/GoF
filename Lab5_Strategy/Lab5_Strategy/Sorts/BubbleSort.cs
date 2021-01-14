using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Strategy
{
    class BubbleSort : StrategySort
    {
        public BubbleSort()
        {
            Title = "Сортировка пузырьком";
        }
        public override string ToString()
        {
            return Title;
        }
        public override void Sort(int[] array)
        {
            int temp;
            for (var i = 0; i < array.Length - 1; i++)
                for (var j = i + 1; j < array.Length; j++)
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
        }
    }
}
