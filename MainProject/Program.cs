using MainProject;
using MyLibrary;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        //create pupils
        Pupil[] pupils = new Pupil[5];
        pupils[0] = new Pupil();
        pupils[1] = new Pupil("Andrey", "Andreev", 16);
        pupils[2] = new Pupil("Ivan", "Ivanov", 10, 5);
        pupils[3] = new Pupil("Anya", "Novikova", 15, 10);
        pupils[4] = new Pupil("Olya", "Sergeeva", 15, 11);
        //methods with pupils
        pupils[0].GetFullName();
        pupils[1].GetInfo();
        pupils[4].Study();
        //create teachers
        Teacher[] teachers = new Teacher[10];
        teachers[0] = new Teacher();
        teachers[1] = new Teacher("Oksana", "Radukevich", 37, "Math");
        teachers[2] = new Teacher("Ivan", "Ivanov", 40);
        teachers[3] = new Teacher("Anna", "Kotikova", 25, "History");
        teachers[4] = new Teacher("Tatsiana", "Pavluk", 51, "Chemistry");
        //methods with teachers
        teachers[0].GetFullName();
        teachers[1].GetInfo();
        teachers[4].Teach();
        //create schools
        School school1 = new School();
        School school2 = new School("Liceum", 101, pupils, teachers);
        //methods with schools
        school1.GetInfo();
        school2.AllTeachers();
        school2.AllPupils();
        school2.AllPupilsWithNames();
        school2.AllTeachersWithNames();
        school2.PupilsRegardingGrade();
        school2.AddTeacher();
        school2.AllTeachersWithNames();

    }
}