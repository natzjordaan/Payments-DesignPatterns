namespace Factory3.Autos
{
    public interface IPayment
    {
        string Name { get; }
        void SetName(string name);
        void Process();
        
    }
}