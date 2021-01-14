using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_TemplateMethod.CakeBake
{
    class CustardCream : BakeCake
    {
        public CustardCream(string size, string form, int weight) : base(size, form, weight) { }
        public override void AddCream()
        {
            Console.WriteLine("Изготовители решили поэкспериментировать и добавить заварной крем");
        }
    }
}
