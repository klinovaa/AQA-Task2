using System.Diagnostics;

namespace MyLibrary
{
    public class Pupil
    {
        public string firstName;
        public string lastName;
        public int age;
        public int grade;
        public Pupil()
        {
            firstName = "No";
            lastName = "name";
            age = 14;
            grade = 9;
        }
        public Pupil(string firstName, string lastName, int age, int grade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.grade = grade;
        }
        public Pupil(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
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