using Lab5_Strategy.Navigator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 31, 15, 10, 2, 4, 2, 14, 23, 12, 66 };
            StrategySort sort = new SelectionSort();
            Context context = new Context(sort, arr1);
            context.Sort();
            context.PrintArray();

            int[] arr2 = { 1, 5, 10, 2, 4, 12, 14, 23, 12, 66 };
            sort = new InsertionSort();
            context = new Context(sort, arr2);
            context.Sort();
            context.PrintArray();

            int[] arr3 = { 1, 15, 19, 25, 34, 12, 17, 32, 12, 6 };
            sort = new BubbleSort();
            context = new Context(sort, arr3);
            context.Sort();
            context.PrintArray();

            Console.WriteLine();
            string start = "ул. Советская";
            string finish = "ул. Ленина";

            StrategyNavigator nav = new CarGo();
            NavigatorContext cont = new NavigatorContext(nav, start, finish);
            cont.Go();

            nav = new FootGo();
            cont = new NavigatorContext(nav, start, finish);
            cont.Go();

            nav = new BikeGo();
            cont = new NavigatorContext(nav, start, finish);
            cont.Go();

            Console.ReadKey();
        }
    }
}
