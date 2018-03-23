using System;
using System.Collections.Generic;

namespace BuilderDemo
{
    public class CardPaymentBuilder : PaymentBuilder
    {
        public override void ApplyTax()
        {
            payment.Tax = payment.Amount * .01;
        }

        public override void ApplyDiscount()
        {
            payment.Discount = payment.Amount * .001;
        }

        public override void getPaymentInfo()
        {
            payment.PaymentType = PaymentTypes.Cards;
        }
    }
}