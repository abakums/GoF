using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Command
{
    class Add : Command
    {
        public Add(ArithmeticUnit unit, double operand)
        {
            this.unit = unit;
            this.operand = operand;
        }
        public override void Execute()
        {
            unit.Run('+', operand);
        }
        public override void UnExecute()

        {
            unit.Run('-', operand);
        }
    }
    //добавлена команда вычитания
    internal class Sub : Command
    {
        public Sub(ArithmeticUnit un, double op)
        {
            unit = un;
            operand = op;
        }

        public override void Execute()
        {
            unit.Run('-', operand);
        }

        public override void UnExecute()
        {
            unit.Run('+', operand);
        }
    }
    //+умножение
    internal class Mul : Command
    {
        public Mul(ArithmeticUnit un, double op)
        {
            unit = un;
            operand = op;
        }

        public override void Execute()
        {
            unit.Run('*', operand);
        }

        public override void UnExecute()
        {
            unit.Run('/', operand);
        }
    }
    //деление
    internal class Div : Command
    {
        public Div(ArithmeticUnit un, double op)
        {
            unit = un;
            operand = op;
        }

        public override void Execute()
        {
            unit.Run('/', operand);
        }

        public override void UnExecute()
        {
            unit.Run('*', operand);
        }
    }
}
