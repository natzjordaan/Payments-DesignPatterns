using System;

namespace Factory3.Autos
{
    public class ECheck : IPayment
    {
        public ECheck()
        {
                
        }
        public ECheck(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public void SetName(string name)
        {
            if (name == null) throw new ArgumentNullException("name");

            Name = name;
        }

        public void Process()
        {
            Console.WriteLine("The " + Name + " is accpeting here and it super easy now.");
        }
    }
}