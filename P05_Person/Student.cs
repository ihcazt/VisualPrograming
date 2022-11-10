namespace P05_Person
{
    public class Student : Person
    {
        // fields
        private int averageMark = 0;

        // constructors
        public Student(int id) : base(id)
        {
        }

        // properties
        public string Collage { get; set; }
        public string Faculty { get; set; }

        // methods
        public void SetAverageMark(int averageMark)
        {
            this.averageMark = averageMark;
        }

        public override string ToString()
        {
            return $"{{{nameof(Collage)}={Collage}, {nameof(Faculty)}={Faculty}, {nameof(SetAverageMark)}={averageMark}, {nameof(Id)}={Id}, {nameof(FirstName)}={FirstName}, {nameof(LastName)}={LastName}, {nameof(Address)}={Address}}}";
        }
    }
}
