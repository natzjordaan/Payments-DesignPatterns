using System;
using Factory4.PaymentTypes;
using Factory4.PaymentTypes.Echecks;

namespace Factory4.Factory
{
    public class EchecksFactory : IPaymentFactory
    {
        public IPayment ProcessDebit()
        {
            var type = new Echecks();

            type.Debit();

            return type;
        }

        public IPayment ProcessCredit()
        {
            var type = new Echecks();

            type.Credit();

            return type;
        }
    }
}
