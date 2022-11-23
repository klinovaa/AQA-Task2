using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    public class LinkedLists
    {
        const int firstElement = 2;
        const int secondElement = 10;

        public static void AddSecondElementAfterFirst(LinkedList<int> list)
        {
            List<int> helpList = new List<int>();
            var currentNode = list.First.Value;
            while (true)
            {
                if (currentNode == firstElement)
                {
                    helpList.Add(currentNode);
                    helpList.Add(secondElement);
                    list.RemoveFirst();
                }
                else
                {
                    helpList.Add(currentNode);
                    list.RemoveFirst();
                }

                if (list.Count == 0)
                {
                    break;
                }

                currentNode = list.First.Value;
            }

            foreach (var item in helpList)
            {
                list.AddLast(item);
            }

            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
        }

        public static void JoinCollections(LinkedList<int> list1, LinkedList<int> list2)
        {
            LinkedList<int> listCommon = new LinkedList<int>();
            
            foreach (var item in list1)
            {
                if (list2.Contains(item))
                {
                    listCommon.AddLast(item);
                    Console.Write($"{item} ");
                }
            }
        }
    }
}
