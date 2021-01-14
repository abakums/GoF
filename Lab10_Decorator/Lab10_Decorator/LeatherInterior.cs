using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Decorator
{
    class LeatherInterior : DecoratorOptions
    {
        public LeatherInterior(AutoBase p, string t) : base(p, t)
        {
            AutoProperty = p;
            Name = p.Name + ". Комфортный";
            Description = p.Description + ". " + this.Title +
                ". Кожаный салон";
        }
        public override double GetCost()
        {
            return AutoProperty.GetCost() + 10.99;
        }
    }
}
