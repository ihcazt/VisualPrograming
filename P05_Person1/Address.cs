namespace P05_Person
{
    /// <summary>
    /// An address.
    /// </summary>
    public class Address
    {
        // properties
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Country)}={Country}, {nameof(City)}={City}, {nameof(Street)}={Street}, {nameof(Number)}={Number.ToString()}}}";
        }
    }
}
