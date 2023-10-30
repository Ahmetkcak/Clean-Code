namespace SModel
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Adres Adres { get; set; } // -> 1 + 2 = 3
    }
}
