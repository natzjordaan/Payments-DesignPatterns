using System;

namespace Factory2.Autos
{
    public class Echeck : IPayment
    {
        public string Name
        {
            get { return "Echeck"; }
        }

        public void Process()
        {
            Console.WriteLine(this.Name + "is processing and its take 1 hour to complete the process.");
        }
    }
}