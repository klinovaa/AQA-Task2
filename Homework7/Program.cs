using Homework7;
using MyLibrary;
using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
        //TASK 1
        Cat cat1 = new Cat
        {
            kind = "Cat",
            Age = 3,
            Speed = 20,
            Color = "Black",
            isDomestic = true
        };
        Person person1 = new Person("Ivan", "Ivanov");
        cat1.PersonForCat(person1);
        cat1.Speak();
        cat1.OvercomeDistance(2);
        cat1.MiceAreCaught(1);

        Dolphin dolphin1 = new Dolphin("Dolphin", 10, 48, false);
        dolphin1.OvercomeDistance(10);
        dolphin1.Eat();
        dolphin1.Speak();
        dolphin1.GetHomeForDolphin();

        //TASK 2
        Console.WriteLine("_________________");
        Ship ship1 = new Ship();
        ship1.Cargo = "Cars";
        ship1.Swim();
        Console.WriteLine(ship1.Direction);
        ship1.TransportCargo();
        Truck truck1 = new Truck();
        truck1.Cargo = "Cement";
        truck1.StartEngine();
        truck1.TransportCargo();


    }
}