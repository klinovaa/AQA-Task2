using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    public class List2
    {
        public static void FindWordOfFiveChars(List<string> list)
        {
            foreach (string word in list)
            {
                if (word.Length == 5)
                {
                    Console.WriteLine(word);
                }
            }
        }

        public static void FindWordOfAnyChars(List<string> list)
        {
            Console.WriteLine("Input the length of the search word:");
            int inputedValue = Convert.ToInt32(Console.ReadLine());
            var selectedNumbers = list.Where(p => p.Length == inputedValue);
            foreach (string word in selectedNumbers)
            {
                Console.WriteLine(word);
            }
        }
    }
}
