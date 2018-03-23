using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderDemo
{
    public class Payment
    {
        public Methods Method { get; set; }
        public double Amount { get; set; }
        public double Tax { get; set; }
        public double Discount { get; set; }
        public PaymentTypes PaymentType { get; set; }

        public void Display()
        {
            Console.WriteLine("Method: {0}", PaymentType);
            Console.WriteLine("Payment Type {0}", Method);
            Console.WriteLine("Amount: {0}", Amount);
            Console.WriteLine("Tax: {0}", Tax);
            Console.WriteLine("Discount: {0}", Discount);          

        }
    }

    public enum Methods
    {
        Credit,
        Debit
    }

    public enum PaymentTypes
    {
        Cards,
        PayPal
    }

}
