using Homework7;
using MyLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
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

    }
}