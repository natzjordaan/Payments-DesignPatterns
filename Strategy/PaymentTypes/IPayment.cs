using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.PaymentTypes
{
    public interface IPayment
    {
        void ProcessPayment(Order order);
    }
}
