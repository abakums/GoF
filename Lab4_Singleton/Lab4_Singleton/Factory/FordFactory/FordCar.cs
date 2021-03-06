﻿using Lab4_Singleton.Factory.CarFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Singleton.Factory.FordFactory
{
    class FordCar : AbstractCar
    {
        public FordCar(string name) => Name = name;
        public override int MaxSpeed(AbstractEngine engine) => engine.MaxSpeed;
        public override string ToString() => "Car " + Name;
    }
}
