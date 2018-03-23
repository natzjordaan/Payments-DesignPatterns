using System;

namespace Factory2.Autos
{
    public class Credit : IPayment
    {
        public string Name
        {
            get { return "Credit"; }
        }

        public void Process()
        {
            Console.WriteLine(this.Name + "is processing.");
        }

       
    }
}