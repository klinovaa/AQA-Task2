using Homework9;

internal class Program
{
    private static void Main(string[] args)
    {
        //List<int> numbers = new List<int>() { 1, 8, 15, 111, 22, 10, 0, 4, 9, 100, 12 };
        //List<string> words = new List<string>() { "Hello", "World", "there", "are", "worlds", "with", "different", "lenght", "Darya", "i am" };

        ////task1-2 list
        //List1.FindEvenNumbers(numbers);

        ////task3 list
        //List2.FindWordOfFiveChars(words);
        //List2.FindWordOfAnyChars(words);

        ////task1 Queue
        //Queue<int> numbersQueue = new Queue<int>();
        //Queue.AddNewValue(numbersQueue);
        //var maxValue = Queue.GetMaxValue(numbersQueue);
        //Console.WriteLine(maxValue);

        ////task2 Stack
        //Stack<char> charsStack = new Stack<char>();
        //Stack.ReverseThreeChars(charsStack);

        //task1 Dictionary
        Dictionary<int, string> people = new Dictionary<int, string>();
        people.Add(25, "Darya");
        people[15] = "Anna";
        people.TryGetValue(25, out string value);
        Console.WriteLine($"Age: 25, Name is {value}");





    }
}