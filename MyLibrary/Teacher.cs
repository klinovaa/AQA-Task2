using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Teacher
    {
        public string firstName;
        public string lastName;
        public int age;
        public string subject;
        public Teacher()
        {
            firstName = "No";
            lastName = "name";
            subject = "Undefined";
        }
        public Teacher(string firstName, string lastName, int age, string subject)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.subject = subject;
        }
        public Teacher(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            subject = "Undefined";
        }
        public void GetInfo()
        {
            Console.WriteLine($"Teacher's first name: {firstName}, teacher's last name: {lastName}, teacher's age: {age}");
        }
        public void GetFullName()
        {
            Console.WriteLine($"First name: {firstName}, Last name: {lastName}");
        }
        public void Teach()
        {
            switch (subject)
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
