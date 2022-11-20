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
        List2.FindWordOfAnyChars(words);
    }
}