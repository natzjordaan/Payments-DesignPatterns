namespace Factory1.Autos
{
    public interface IPayment
    {
        string Name { get; }
        void Process();
    }
}