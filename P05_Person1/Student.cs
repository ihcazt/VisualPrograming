namespace P05_Person
{
    public class Student : Person
    {
        public Student(int id) : base(id)
        {
        }

        // properties
        public string Collage { get; set; }
        public string Faculty { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Collage)}={Collage}, {nameof(Faculty)}={Faculty}, {nameof(Id)}={Id.ToString()}, {nameof(FirstName)}={FirstName}, {nameof(LastName)}={LastName}, {nameof(Address)}={Address}}}";
        }
    }
}
