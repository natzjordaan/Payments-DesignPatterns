using System;
using System.Collections.Generic;
using System.Reflection;
using Factory4.PaymentTypes;
using Factory4.PaymentTypes.Card;

namespace Factory4.Factory
{
    public class CardFactory : IPaymentFactory
    {
        public IPayment ProcessDebit()
        {
            return new Debit();
        }

        public IPayment ProcessCredit()
        {
            return new Credit();
        }
    }
}
