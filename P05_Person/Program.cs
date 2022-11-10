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

            student.SetAverageMark(98);

            Console.WriteLine(student);
        }
    }
}

// Exercises
// 1. Write a class of Lecturer similar to the class of Student.
//    Demonstrate the class in the Main.
// 2. Write a class of bank account (name it BankAccount).
//    Each bunk account has an owner and a balance.
//        The owner is a person.
//        The balance is a double number.
//    The bank account also has the following methods:
//        Withdraw(int amount) - withdraw amount of money
//        Depose(int amount) - depose amount of money
//        ToString - 
//    Demonstrate the class in the Main. 
