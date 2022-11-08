using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Pupil = MyLibrary.Pupil;
using Teacher = MyLibrary.Teacher;

namespace MainProject
{
    internal class School
    {
        public string type;
        public int number;
        public Pupil[] pupils;
        public Teacher[] teachers;

        public School()
        {
            type = "School is undefined";
            number = 0;
        }
        public School(string type, int number, Pupil[] pupils, Teacher[] teachers)
        {
            this.type = type;
            this.number = number;
            this.pupils = pupils;
            this.teachers = teachers;
        }
        public void GetInfo()
        {
            Console.WriteLine($"School's type - {type}, school's number: {number}");
        }
        public void AllPupils()
        {
            Console.WriteLine($"Amount of all pupils - {pupils.Length}");
        }
        public void AllTeachers()
        {
            Console.WriteLine($"Amount of all teachers - {teachers.Length}");
        }
        public void AllPupilsWithNames() 
        {
            Console.WriteLine("All pupils:");
            for (int i = 0; i < pupils.Length; i++)
            {
                pupils[i].GetFullName();
            }
        }
        public void AllTeachersWithNames()
        {
            Console.WriteLine("All teachers:");
            for (int i = 0; i < teachers.Length; i++)
            {
                if (teachers[i] == null)
                    break;
                teachers[i].GetFullName();
            }
        }
        public void PupilsRegardingGrade()
        {
            Console.WriteLine("Pupils in 10th grade:");
            for (int i = 0; i < pupils.Length; i++)
            {
                if (pupils[i].grade == 10)
                {
                    pupils[i].GetFullName();
                }
            }
        }
        public void AddTeacher()
        {
            for (int i = 0; i < teachers.Length; i++)
            {
                if (teachers[i] == null)
                {
                    Console.WriteLine("Input teacher's first name:");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Input teacher's last name:");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Input teacher's age:");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input teacher's subject:");
                    string subject = Console.ReadLine();
                    teachers[i] = new Teacher(firstName, lastName, age, subject);
                    break;
                }
            }
        }

    }
}
