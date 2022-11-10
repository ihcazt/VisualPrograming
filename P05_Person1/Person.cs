namespace P05_Person
{
    public class Person
    {
        /// <summary>
        /// Constructs a person with a given identification.
        /// </summary>
        /// <param name="id"></param>
        public Person(int id)
        {
            Id = id;
        }

        // properties
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(FirstName)}={FirstName}, {nameof(LastName)}={LastName}, {nameof(Address)}={Address}}}";
        }
    }
}
