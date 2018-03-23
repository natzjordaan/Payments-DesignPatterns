using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderDemo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Amount");
            string value = Console.ReadLine();
            double amount =  Convert.ToDouble(value);
            
            var paypal = new PaymentProcessor(new PayPalBuilder());
            paypal.ProcessPayment(amount);
            var payment1 = paypal.GetPayment();
            PrintHeader("PayPal");
            payment1.Display();

            var card = new PaymentProcessor(new CardPaymentBuilder());
            card.ProcessPayment(amount);
            var payment2 = card.GetPayment();
            PrintHeader("Cards");
            payment2.Display();
            Console.ReadKey();
        }

        static void PrintHeader(string title)
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++ {0} ++++++++++++++++++", title);

        }
    }
}
