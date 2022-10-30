using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        //firstHomework();
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        Task6();
        Task7();
        Task8();
        Task9();
    }

    private static void firstHomework()
    {
        Console.WriteLine("Hi! What’s your name?");
        var name = Console.ReadLine();
        Console.WriteLine($"Nice to meet you {name}");
    }

    private static void Task1()
    {
        var num = 20;
        num += 5;
        Console.WriteLine($"Переменная: {num}");
    }
    private static void Task2()
    {
        Console.WriteLine("Input 4 digit number");
        string number = Console.ReadLine();
        if (number.Length == 4 )
        {
            int inputDays = Convert.ToInt16(number);
            int years = inputDays / 365;
            int month = (inputDays % 365) / 30;
            int days = (inputDays % 365) % 30;
            Console.WriteLine($"{years} years, {month} month, {days} days");
        }
        else
        {
            Console.WriteLine("Input 4 digit number!");
        }

    }
    private static void Task3()
    {
        Console.WriteLine("Input any number");
        string inputNumber = Console.ReadLine();
        int number = Convert.ToInt16(inputNumber);
        Console.WriteLine(number + number * 2);
    }
    private static void Task4()
    {
        sbyte n1 = -34;
        byte n2 = 4;
        string greeting = "Hello";
        char a = 'R';
        double n3 = 23.093433222;
        ushort n4 = 4000;
        bool isB = true;
        byte n5 = 0;  
    }
    private static void Task5()
    {
        Console.WriteLine("Input any data");
        string inputData = Console.ReadLine();
        short number = Convert.ToInt16(inputData);
        ulong number2 = Convert.ToUInt64(inputData);
        char char1 = Convert.ToChar(inputData.First());
        double number3 = Convert.ToDouble(inputData);
    }
    private static void Task6()
    {
        int n1 = -5;
        int n2 = n1 * 7;
        n1--;
    }
    private static void Task7()
    {
        Console.WriteLine("Input any number");
        string inputNumber = Console.ReadLine();
        if (Convert.ToInt64(inputNumber) % 2 == 0)
        {
            Console.WriteLine("This number is even!");
        }
        else
        {
            Console.WriteLine("This number is odd!");
        }
    }
    private static void Task8()
    {
        Console.WriteLine("Input any number");
        string inputNumber = Console.ReadLine();
        int a = Convert.ToInt32(inputNumber);
        if ( ((a < 50 & a != 37) && (a >= 32)) || ( a == 15 | a == 0))
        {
            Console.WriteLine("Working");
        }
        else
        {
            Console.WriteLine("Not working!:(");
        }
    }

    private static void Task9()
    {
        Console.WriteLine("Input number 1");
        string inputNumber = Console.ReadLine();
        Console.WriteLine("Input number 2");
        string inputNumber2 = Console.ReadLine();
        Console.WriteLine("Input arithmetic operation: +, -, * or /");
        char operation = Convert.ToChar(Console.ReadLine());
        switch (operation)
        {
            case '+':
                Console.WriteLine(Convert.ToInt64(inputNumber) + Convert.ToInt64(inputNumber2));
                break;
            case '-':
                Console.WriteLine(Convert.ToInt64(inputNumber) - Convert.ToInt64(inputNumber2));
                break;
            case '*':
                Console.WriteLine(Convert.ToInt64(inputNumber) * Convert.ToInt64(inputNumber2));
                break;
            case '/':
                Console.WriteLine(Convert.ToInt64(inputNumber) / Convert.ToInt64(inputNumber2));
                break;
        }
    }
}