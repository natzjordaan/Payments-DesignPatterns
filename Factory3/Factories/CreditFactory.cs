using Factory3.Autos;

namespace Factory3.Factories
{
    class CreditFactory : IPaymentFactory
    {
        public IPayment StartProcessing()
        {
            return new Credit("BMW M5 Cabriolet");
        }
    }
}