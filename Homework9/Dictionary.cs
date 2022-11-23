using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    public class Dictionary
    {
        public static void SortAndUnite(List<int> list1, List<string> list2)
        {
            list1.Sort();
            list2.Sort();
            list2.Reverse();

            Dictionary<int, string> unitedLists = new Dictionary<int, string>();
            for (var i = 0; i < 10; i++)
            {
                unitedLists.Add(list1[i], list2[i]);
            }

            foreach (var item in unitedLists)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
        }
    }
}
