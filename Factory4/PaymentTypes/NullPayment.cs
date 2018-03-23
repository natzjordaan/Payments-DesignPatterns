namespace Factory4.PaymentTypes
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