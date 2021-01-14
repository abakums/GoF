using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Decorator
{
    class SteelWheels : DecoratorOptions
    {
        public SteelWheels(AutoBase p, string t) : base(p, t)
        {
            AutoProperty = p;
            Name = p.Name + ". Проходимый";
            Description = p.Description + ". " + this.Title +
                ". Стальные диски, улучшенный протектор колес";
        }
        public override double GetCost()
        {
            return AutoProperty.GetCost() + 23.99;
        }
    }
}
