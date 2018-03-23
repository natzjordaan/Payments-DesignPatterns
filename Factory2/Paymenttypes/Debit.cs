using System;

namespace Factory2.Autos
{
    public class Debit : IPayment
    {
        public string Name
        {
            get { return "Debit"; }
        }

        public void Process()
        {
            Console.WriteLine(this.Name + "is processing and its easier.");
        }
    }
}