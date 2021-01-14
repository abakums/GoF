using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Command
{
    class Calculator
    {
        ArithmeticUnit arithmeticUnit;
        ControlUnit controlUnit;
        public Calculator()
        {
            arithmeticUnit = new ArithmeticUnit();
            controlUnit = new ControlUnit();
        }
        private double Run(Command command)
        {
            controlUnit.StoreCommand(command);
            controlUnit.ExecuteCommand();
            return arithmeticUnit.Register;
        }
        public double Add(double operand)
        {
            return Run(new Add(arithmeticUnit, operand));
        }
        public double Redo()
        {
            controlUnit.Redo();
            return arithmeticUnit.Register;
        }
        //добавлены методы математических действий в калькулятор
        public double Sub(double operand)
        {
            return Run(new Sub(arithmeticUnit, operand));
        }

        public double Mul(double operand)
        {
            return Run(new Mul(arithmeticUnit, operand));
        }

        public double Div(double operand)
        {
            return Run(new Div(arithmeticUnit, operand));
        }
        //добавлены методы многоуровневой отмены и повтора операций
        public double Redo(int i)
        {
            controlUnit.Redo(i);
            return arithmeticUnit.Register;
        }

        public double Undo()
        {
            controlUnit.Undo();
            return arithmeticUnit.Register;
        }

        public double Undo(int i)
        {
            controlUnit.Undo(i);
            return arithmeticUnit.Register;
        }
    }
}
