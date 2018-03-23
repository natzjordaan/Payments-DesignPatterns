using Factory3.Autos;

namespace Factory3.Factories
{
    public interface IPaymentFactory
    {
        IPayment StartProcessing();
    }

}