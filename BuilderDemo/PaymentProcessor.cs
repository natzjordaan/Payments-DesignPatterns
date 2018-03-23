using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderDemo
{
    public class PaymentProcessor
    {
        private readonly PaymentBuilder builder;

        public PaymentProcessor(PaymentBuilder builder)
        {
            this.builder = builder;
        }

        public void ProcessPayment(double amount)
        {
            builder.CreateNewPayment(amount);
            builder.getPaymentInfo();
            builder.ApplyDiscount();
            builder.ApplyTax();
        }
            

        public Payment GetPayment()
        {
            return builder.GetPayment();
        }
    }
}
