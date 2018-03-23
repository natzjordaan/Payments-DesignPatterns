using System;

namespace Factory4.PaymentTypes.Card
{
    public class Credit : CardBase
    {
        public override string Name
        {
            get { return "Credit"; }
        }

        public override void Process()
        {
            Console.WriteLine("The " + Name + " is accepting here and its super easy.");
        }
    }
}