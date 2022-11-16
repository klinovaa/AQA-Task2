using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        //Constructor chaining
        //1st constructor
        public Person() : this("No", "name")
        {
        }

        //2nd constuctor
        public Person(string firstName, string lastName) : this(firstName, lastName, 0)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        //3rd constructor
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Person's first name: {FirstName}, person's last name: {LastName}, person's age: {Age}");
        }

        public void GetFullName()
        {
            Console.WriteLine($"First name: {FirstName}, Last name: {LastName}");
        }

    }
}
