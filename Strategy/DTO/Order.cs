namespace Strategy
{
    public class Order
    {
        public Address Destination { get; set; }
        public Address Origin { get; set; }
        public Types type { get; set; }
    }
}