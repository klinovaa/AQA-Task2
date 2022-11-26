using Homework10;
using Homework7;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //var cats = new GenericClass<Cat>(7); can't create cats after GenericClass<T> where T : Human
        var man = new GenericClass<Man>(5);
        var woman = new GenericClass<Woman>(2);

        man.AddElement(new Man("James", "Bond"), 0);
        man.AddElement(new Man("Albus", "Dambldor"), 1);
        man.AddElement(new Man("Chandler", "Bing"), 2);
        man.AddElement(new Man("Dan", "Wall"), 3);
        man.AddElement(new Man("Allen", "D"), 4);
        man.DeleteElement(4);

        Generate<Woman>(2, woman);
        GenericClass<Woman>.ToString(woman);
        GenericClass<Man>.ToString(man);
    }

    public static void Generate<T>(int numberOfHumans, GenericClass<T> generatedHumans) where T : Human, new()
    {
        string name;
        string surname;
        for (int i = 0; i < numberOfHumans; i++)
        {
            Console.WriteLine("Input name for human");
            name = Console.ReadLine();
            Console.WriteLine("Input surname for human");
            surname = Console.ReadLine();
            var womanOrMan = new T();
            womanOrMan.Name = name;
            womanOrMan.Surname = surname;
            if (typeof(T) == typeof(Woman))
            {
                generatedHumans.AddElement(womanOrMan, i);
            }
            else if (typeof(T) == typeof(Man))
            {
                generatedHumans.AddElement(womanOrMan, i);
            }
        }
    }
}