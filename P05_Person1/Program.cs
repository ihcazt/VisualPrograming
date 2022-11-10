using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Person
{
    public static class Program
    {
        public static void Main()
        {
            Address address = new Address
            {
                Country = "Israel",
                City = "Jerusalem",
                Street = "Ben-Yehuda",
                Number = 25
            };

            Console.WriteLine(address);

            Person person = new Person(1)
            {
                FirstName = "Bella",
                LastName = "Levi",
                Address = address
            };

            Console.WriteLine(person);

            Student student = new Student(2)
            {
                Address = address,
                FirstName = "Haiim",
                LastName = "Choen",
                Collage = "Achava",
                Faculty = "Information System"
            };

            Console.WriteLine(student);
        }
    }
}
