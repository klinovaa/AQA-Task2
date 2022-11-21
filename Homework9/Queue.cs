using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    public class Queue
    {
        public static int GetMaxValue(Queue<int> queue)
        {
            return queue.Max();
        }

        public static void AddNewValue(Queue<int> queue)
        {
            Console.WriteLine("Input values to queue and type 'quit' when you want to quit");
            
            while(true)
            {
                var inputNumber = Console.ReadLine();
                
                if (inputNumber == "quit")
                {
                    break;
                }
                else
                {
                    try 
                    {
                        queue.Enqueue(Convert.ToInt32(inputNumber));
                    }
                    catch
                    {
                        Console.WriteLine("Input number, please!");
                    }
                }
            }
        }
    }
}
