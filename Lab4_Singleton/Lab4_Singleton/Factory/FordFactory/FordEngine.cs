﻿using Lab4_Singleton.Factory.CarFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Singleton.Factory.FordFactory
{
    class FordEngine : AbstractEngine
    {
        public FordEngine() => MaxSpeed = 200;
    }
}
