
namespace DaryaKlinavaSaysHello
{
    public class Homework1to4
    {
        private static void firstHomework()
        {
            Console.WriteLine("Hi! What’s your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Nice to meet you {name}");
        }
        private static void Task1_1()
        {
            var num = 20;
            num += 5;
            Console.WriteLine($"Переменная: {num}");
        }
        private static void Task1_2()
        {
            Console.WriteLine("Input 4 digit number");
            string number = Console.ReadLine();
            if (number.Length == 4)
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
        private static void Task1_3()
        {
            Console.WriteLine("Input any number");
            string inputNumber = Console.ReadLine();
            int number = Convert.ToInt16(inputNumber);
            Console.WriteLine(number + number * 2);
        }
        private static void Task1_4()
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
        private static void Task1_5()
        {
            Console.WriteLine("Input any data");
            string inputData = Console.ReadLine();
            short number = Convert.ToInt16(inputData);
            ulong number2 = Convert.ToUInt64(inputData);
            char char1 = Convert.ToChar(inputData.First());
            double number3 = Convert.ToDouble(inputData);
        }
        private static void Task1_6()
        {
            int n1 = -5;
            int n2 = n1 * 7;
            n1--;
        }
        private static void Task1_7()
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
        private static void Task1_8()
        {
            Console.WriteLine("Input any number");
            string inputNumber = Console.ReadLine();
            int a = Convert.ToInt32(inputNumber);
            if (((a < 50 & a != 37) && (a >= 32)) || (a == 15 | a == 0))
            {
                Console.WriteLine("Working");
            }
            else
            {
                Console.WriteLine("Not working!:(");
            }
        }
        private static void Task1_9()
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

        private static void Task2_1()
        {
            Console.WriteLine("Input any number");
            uint inputNumber = Convert.ToUInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <= inputNumber; i++)
            {
                sum += i;
                if (i == inputNumber)
                    Console.WriteLine(sum);
            }
        }

        private static void Task2_2()
        {
            int i = 0;
            while (i < 10)
            {
                i++;
                Console.WriteLine($"3 * {i} = {3 * i}");
            }
        }

        private static void Task2_3()
        {
            int[] numbers = new int[] { 3, 5, 9, 8, 15 };
            int result = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                result *= numbers[i];
                if (i == numbers.Length - 1)
                    Console.WriteLine(result);
            }
        }

        private static void Task2_4()
        {
            int initialNumber = 2048;
            for (int i = 1; initialNumber > 10; i++)
            {
                initialNumber /= 2;
                if (initialNumber < 10)
                    Console.WriteLine(i);
            }
        }

        private static void Task2_5()
        {
            string[] names = new string[] { "oh", "no", "henlo, human", "Blablabla", "hello", "Hello", ":(" };
            foreach (string i in names)
            {
                if (i == "Hello")
                {
                    Console.WriteLine("Labas!");
                    break;
                }
            }
        }

        private static void Task2_6()
        {
            int[] numbers = new int[] { 1, 11111, 123, 0, -299, 234, 999 };
            Console.WriteLine(numbers[0] + numbers[numbers.Length - 1]);
        }

        private static void Task2_7()
        {
            int[] numbers = new int[] { 1, 11111, 123, 0, -299, 234, 999 };
            int maxValue = 0;
            int minValue = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    minValue = numbers[i];
                }
                else if (numbers[i] < minValue)
                {
                    minValue = numbers[i];
                }

                if (i == 0)
                {
                    maxValue = numbers[i];
                }
                else if (numbers[i] > maxValue)
                {
                    maxValue = numbers[i];
                }
            }
            int result = 0;
            for (int y = 0; y < numbers.Length; y++)
            {
                if (numbers[y] == minValue)
                {
                    result += y;
                }
                else if (numbers[y] == maxValue)
                {
                    result += y;
                }
            }
            Console.WriteLine(result);
        }

        private static void Task2_8()
        {
            int[] numbers = new int[] { 1, 11111, 123, 0, -299, 234, 999 };
            int changeValue = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int x = i + 1; x < numbers.Length; x++)
                {
                    if (numbers[i] > numbers[x])
                    {
                        changeValue = numbers[i];
                        numbers[i] = numbers[x];
                        numbers[x] = changeValue;
                    }
                }
            }
            foreach (int i in numbers)
            {
                Console.Write($"{i} ");
            }
        }

        private static void Task2_9()
        {
            for (int i = 1; i <= 10; i++)
            {
                int y = 1;
                for (; y <= 10; y++)
                {
                    Console.WriteLine($"{i} * {y} = {i * y}");
                }
            }
        }

        private static void Task2_10()
        {
            int[,] numbers = { { 1, 2, 13 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int result = 0;
            for (int i = 0; i < numbers.GetUpperBound(0) + 1; i++)
            {
                result += numbers[i, i];
            }
            Console.WriteLine(result);
        }
    }
}
