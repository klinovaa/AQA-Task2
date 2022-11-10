using System.Diagnostics;

namespace MyLibrary
{
    public class Pupil
    {
        public string firstName;
        public string lastName;
        public int age;
        public int grade;

        //Constructor chaining
        //1st constructor
        public Pupil() : this("No", "name", 14, 9) 
        {
        }

        //2nd constuctor
        public Pupil(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        //3rd constructor
        public Pupil(string firstName, string lastName, int age, int grade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.grade = grade;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Pupil's first name: {firstName}, pupil's last name: {lastName}, pupil's age: {age}");
        }

        public void GetFullName()
        {
            Console.WriteLine($"First name: {firstName}, Last name: {lastName}");
        }

        public void Study()
        {
            Console.WriteLine($"Pupil study at {grade} grade");
        }
    }
}