using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    public class List1
    {
        public static void FindEvenNumbers(List<int> list)
        {
            int sum = 0;
            foreach (var i in list)
            {                
                if (i%2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
