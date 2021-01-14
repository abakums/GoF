﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_TemplateMethod.CakeBake
{
    class CreamyCream : BakeCake
    {
        public CreamyCream(string size, string form, int weight) : base(size, form, weight) { }
        public override void AddCream()
        {
            Console.WriteLine("Для пышного торта был добавлен лучший сливочный крем!");
        }
    }
}
