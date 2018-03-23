using Factory2.Autos;
using System;

namespace Factory2
{
    /// <summary>
    /// simple factory
    /// </summary>
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Payment Types");
            Console.WriteLine("credit | debit | Echeck ");
            string paymentType = Console.ReadLine();

            PaymentFactory factory = new PaymentFactory();

            IPayment payment = factory.CreateInstance(paymentType);

            payment.Process();
            Console.ReadLine();
        }
    }
}
