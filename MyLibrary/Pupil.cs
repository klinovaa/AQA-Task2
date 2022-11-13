using System.Diagnostics;

namespace MyLibrary
{
    public class Pupil : Person
    {
        public int Grade { get; set; }

        public Pupil()
            : base()
        {
        }

        public Pupil(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {
        }

        public Pupil(string firstName, string lastName, int age, int grade)
            : base (firstName, lastName, age)
        {
            Grade = grade;
        }

        override public void GetInfo()
        {
            Console.WriteLine($"Pupil's first name: {FirstName}, pupil's last name: {LastName}, pupil's age: {Age}");
        }

        public void Study()
        {
            Console.WriteLine($"Pupil study at {Grade} grade");
        }
    }
}