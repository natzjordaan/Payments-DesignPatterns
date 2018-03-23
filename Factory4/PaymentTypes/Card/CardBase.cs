using System;

namespace Factory4.PaymentTypes.Card
{
    public abstract class CardBase : IPayment
    {
        public abstract string Name { get; }

        public virtual void Process()
        {
            Console.WriteLine("The " + Name + " is accepting here.");
        }
        

    }
}