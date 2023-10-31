namespace SModel
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string City { get; set; } // -> 1
        public string Country { get; set; } // -> 2
        public string Town { get; set; } // -> 2
        public string Holl { get; set; } // -> 2



        public Adres Adres { get; set; } // -> 1 + 2 = 3
    }
}
