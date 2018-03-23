using Factory1.Autos;
using System;

namespace Factory1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Payment Types");
            Console.WriteLine("credit | debit | Echeck ");
            string paymentType = Console.ReadLine();

            IPayment payment = GetProcessingMethod(paymentType);
            payment.Process();
            Console.ReadLine();
        }

        static IPayment GetProcessingMethod(string paymentType)
        {
            switch (paymentType)
            {
                case "credit":
                    return new Credit();
                case "debit":
                    return new Debit();
                case "Echeck":
                    return new Echeck();
                default:
                    return new NullPayment();
            }    
        }
    }
}
