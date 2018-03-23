namespace Factory2.Autos
{
    public interface IPayment
    {
        string Name { get; }
        void Process();
    }
}