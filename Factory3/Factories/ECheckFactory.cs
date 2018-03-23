using Factory3.Autos;

namespace Factory3.Factories
{
    class ECheckFactory : IPaymentFactory
    {
        public IPayment StartProcessing()
        {
            var type = new ECheck();
            type.SetName("Echeck online");            
            return type;
        }
    }
}