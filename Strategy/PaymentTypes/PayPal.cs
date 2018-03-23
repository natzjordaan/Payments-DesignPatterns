using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.PaymentTypes
{
    public class PayPal : IPayment
    {
        public void ProcessPayment(Order order)
        {
            Console.WriteLine("PayPal");
        }
    }
   
}
