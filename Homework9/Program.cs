using Homework9;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 1, 8, 15, 111, 22, 10, 0, 4, 9, 100, 12 };
        List<string> words = new List<string>() { "Hello", "World", "there", "are", "worlds", "with", "different", "lenght", "Darya", "i am" };

        //task1-2 list
        List1.FindEvenNumbers(numbers);

        //task3 list
        List2.FindWordOfFiveChars(words);
        //task4 list
        List2.FindWordOfAnyChars(words);

        //task1 Queue
        Queue<int> numbersQueue = new Queue<int>();
        Queue.AddNewValue(numbersQueue);
        var maxValue = Queue.GetMaxValue(numbersQueue);
        Console.WriteLine(maxValue);
        Queue.DeleteMaxValue(numbersQueue);
        maxValue = Queue.GetMaxValue(numbersQueue);
        Console.WriteLine(maxValue);

        //task2 Stack
        Stack<char> charsStack = new Stack<char>();
        Stack.ReverseThreeChars(charsStack);

        //task1 Dictionary
        Dictionary<string, int> people = new Dictionary<string, int>();
        people.Add("Darya", 25);
        people["Anna"] = 15;
        people.TryGetValue("Darya", out int value);
        Console.WriteLine($"Name is \"Darya\", Age - {value}");

        //task2 Dictionary
        List<int> numbersForDictionary = new List<int>() { 1, 8, 15, 111, 22, 10, 0, 4, 9, 100 };
        List<string> wordsForDictionary = new List<string>() { "Hi", "my", "name", "is", "Slim", "Shady", "Hello", "World", "there", "are" };
        Dictionary.SortAndUnite(numbersForDictionary, wordsForDictionary);

        //task1 LinkedList
        List<int> numbers2 = new List<int>() { 2, 4, 3, 2, 8, 2, 5, 1, 2 };
        LinkedList<int> list1 = new LinkedList<int>(numbers2);
        LinkedLists.AddSecondElementAfterFirst(list1);

        //task2 LinkedList
        List<int> numbers3 = new List<int>() { 1, 3, 4, 7, 12 };
        List<int> numbers4 = new List<int>() { 1, 5, 7, 9 };
        LinkedList<int> list2 = new LinkedList<int>(numbers3);
        LinkedList<int> list3 = new LinkedList<int>(numbers4);
        LinkedLists.JoinCollections(list2, list3);

        //task3 Dictionary
        Dictionary<string, City> city = new Dictionary<string, City>();
        city.Add("Venice", new City(258685, 414));
        city.Add("Verona", new City(258031, 206));
        city.Add("Padova", new City(214125, 92));
        city.Add("Rome", new City(4342212, 1285));
        city.Add("Bergamo", new City(121200, 40));
        city.Add("Naples", new City(910439, 117));

        var sortByCityArea = city.OrderBy(x => x.Value.area).ToDictionary(y => y.Key, t => t.Value.area);
        
        foreach (var item in sortByCityArea)
        {
            Console.WriteLine($"{item.Key} {item.Value}");
        }

        var sortByCityPopulation = city.OrderByDescending(x => x.Value.population).ToDictionary(y => y.Key, t => t.Value.population);
        
        foreach (var item in sortByCityPopulation)
        {
            Console.WriteLine($"{item.Key} {item.Value}");
        }

        var commonPopulation = city.ToDictionary(y => y.Key, t => t.Value.population);
        var sum = 0;
        
        foreach (var item in sortByCityPopulation)
        {
            sum += item.Value;
        }
        Console.WriteLine($"Common population is {sum}");
    }
}