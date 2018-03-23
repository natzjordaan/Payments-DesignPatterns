using Strategy.PaymentTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
   public class PaymentService
    {
        public void payment(Order order, Func<Order, IPayment> paymentStrategy)
        {
            paymentStrategy(order).ProcessPayment(order);
        }
    }
}
