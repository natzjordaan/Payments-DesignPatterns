using Strategy.PaymentTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Order, IPayment> PaymentType = PaymentStrategy.GetPaymentType;
            Order theOrder = DummyData.CreateOrder();

            var PaymentService = new PaymentService();
            Console.WriteLine("Payment Type");

            PaymentService.payment(theOrder, PaymentType);

            Console.ReadKey();

        }

      
    }
}
