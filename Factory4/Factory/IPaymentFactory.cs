using Factory4.PaymentTypes;

namespace Factory4.Factory
{
    public interface IPaymentFactory
    {
        IPayment ProcessDebit();
        IPayment ProcessCredit();
    }
}