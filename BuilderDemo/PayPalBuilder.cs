using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderDemo
{
    public class PayPalBuilder : PaymentBuilder
    {
    public override void ApplyTax()
    {
        payment.Tax = payment.Amount * .02;
    }

    public override void ApplyDiscount()
    {
        payment.Discount = payment.Amount * .005;
    }

        public override void getPaymentInfo()
        {
            payment.PaymentType = PaymentTypes.PayPal;
        }

    }
}
