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
    }
}
