namespace Factory2.Autos
{
    public class NullPayment : IPayment
    {
        public string Name
        {
            get { return string.Empty; }
        }

        public void Process()
        {
            
        }
        
    }
}