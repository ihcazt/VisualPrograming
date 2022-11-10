namespace P05_Person
{
    public class Person
    {
        // constructors
        public Person(int id)
        {
            Id = id;
        }

        // properties
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }

        // methods
        public override string ToString()
        {
            return $"Person{{{nameof(Id)}={Id}, {nameof(FirstName)}={FirstName}, {nameof(LastName)}={LastName}, {nameof(Address)}={Address}}}";
        }
    }
}
