using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    public class Stack
    {
        public static void ReverseThreeChars(Stack<char> stack)
        {
            Console.WriteLine("You need to input 3 chars!");
            while (true)
            {
                if (stack.Count == 3)
                {
                    break;
                }

                Console.WriteLine("Input a char, please");
                var inputChar = Console.ReadLine();

                if (inputChar.Length > 1)
                {
                    Console.WriteLine("Input just 1 char, please!");
                }
                else
                {
                    try
                    {
                        stack.Push(Convert.ToChar(inputChar));
                    }
                    catch
                    {
                        Console.WriteLine("Input char, please!");
                    }
                }
            }

            Console.WriteLine("Reverse order:");
            foreach (char c in stack)
            {
                Console.WriteLine(c);
            }
        }
    }
}
