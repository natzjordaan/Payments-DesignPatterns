using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderDemo
{
    public abstract class PaymentBuilder
    {
        protected Payment payment;

        public Payment GetPayment()
        {
            return payment;
        }

        public void CreateNewPayment(double amount)
        {
            payment = new Payment();
            payment.Amount = amount;
        }

        public abstract void getPaymentInfo();
        public abstract void ApplyTax();
        public abstract void ApplyDiscount();

    }
}
