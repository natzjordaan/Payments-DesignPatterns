using System;

namespace Factory4.PaymentTypes.Echecks
{
    public class Echecks : IPayment
    {
        string name;

        public Echecks()
        {
            name = "EChecks";
        }

        public void Debit()
        {
            name += " Debit";
        }

        public void Credit()
        {
            name += " Credit";
        }

        public void Process()
        {
            Console.WriteLine("The " + name + " is on!.");
        }

        
    }
}