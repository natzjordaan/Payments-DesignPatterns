using System;
using System.Reflection;
using Factory4.Factory;

namespace Factory4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Payment Types");
            Console.WriteLine("Card | Echeck ");
            string paymentType = Console.ReadLine();

            IPaymentFactory factory = LoadFactory(paymentType);

            PrintHeader("Credit");
            var pay = factory.ProcessCredit();
            pay.Process();

            PrintHeader("Debit");
            pay = factory.ProcessDebit();
            pay.Process();

            Console.ReadLine();

        }

    
        static IPaymentFactory LoadFactory(string factoryName)
        {
            // string factoryName = Properties.Settings.Default.AutoFactory;
            //this is ugly
            factoryName = "Factory4.Factory." + factoryName + "Factory";          
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IPaymentFactory;
        }

        static void PrintHeader(string title)
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++ {0} ++++++++++++++++++", title);
        
        }
    }
}
