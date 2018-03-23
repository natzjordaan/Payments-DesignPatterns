using Strategy.PaymentTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class PaymentStrategy
    {
        internal static IPayment GetPaymentType(Order arg)
        {
            if (arg.type == Types.Credit)
                return new Credit();
            else if (arg.type == Types.PayPal)
                return new PayPal();
            else
                throw new NotImplementedException();

        }
    }

}
