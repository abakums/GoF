using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_ChainofResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //определяем доступные классы способов оплаты(bank, money, paypal)
            Receiver receiver = new Receiver(false, true, false);
            PaymentHandler bankPaymentHandler = new BankPaymentHandler();
            PaymentHandler moneyPaymentHnadler = new MoneyPaymentHandler();
            PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler();

            //выстраиваем цепочку вызовов
            bankPaymentHandler.Successor = paypalPaymentHandler;
            paypalPaymentHandler.Successor = moneyPaymentHnadler;
            moneyPaymentHnadler.Successor = bankPaymentHandler;
            bankPaymentHandler.Handle(receiver);


            //Если все способы оплаты false, то ничего на экран не будет выведено
            
            //Если цепочка вызовов доходит до того звена, которое обозначает разрешенный способ оплаты, 
            //то он выполняется, иначе ничего на экран не выводится 
            Console.ReadKey();
        }
    }
}
