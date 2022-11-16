using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher()
            : base()
        {
        }

        public Teacher(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {
            Subject = "Undefined";
        }

        public Teacher(string firstName, string lastName, int age, string subject)
            : base(firstName, lastName, age)
        {
            Subject = subject;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Teacher's first name: {FirstName}, teacher's last name: {LastName}, teacher's age: {Age}");
        }

        public void Teach()
        {
            switch (Subject)
            {
                case "Math":
                    Console.WriteLine("Teacher's subject is Math");
                    break;
                case "Biology":
                    Console.WriteLine("Teacher's subject is Biology");
                    break;
                case "Chemistry":
                    Console.WriteLine("Teacher's subject is Chemistry");
                    break;
                case "History":
                    Console.WriteLine("Teacher's subject is History");
                    break;
                case "Physics":
                    Console.WriteLine("Teacher's subject is Physics");
                    break;
                default:
                    Console.WriteLine("Teacher's subject is unknown yet");
                    break;
            }
        }
    }
}
