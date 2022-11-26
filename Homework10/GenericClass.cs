using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    public class GenericClass<T> where T : Human
    {
        private T[] _array;

        public GenericClass(int size)
        {
            _array = new T[size];
        }

        public void AddElement(T element, int index)
        {
            _array[index] = element;
        }

        public void DeleteElement(int index)
        {
            T[] helpArray = new T[_array.Length - 1];
            for (int i = 0, j = 0; i < _array.Length; i++)
            {
                if (i != index)
                {
                    helpArray[j] = _array[i];
                    j++;
                }
            }
            _array = helpArray;
        }

        public T GetElementByIndex(int index)
        {
            return _array[index];
        }

        public int GetArrayLength()
        {
            return _array.Length;
        }

        public static void ToString(GenericClass<T> collection)
        {
            if (typeof(T) == typeof(Woman))
            {
                Console.WriteLine($"There are only woman");
            }
            else if (typeof(T) == typeof(Man))
            {
                Console.WriteLine($"There are only man");
            }
            for (int i = 0; i < collection.GetArrayLength(); i++)
            {
                Console.WriteLine($"Name is {collection.GetElementByIndex(i).Name}, surname is {collection.GetElementByIndex(i).Surname}");
            }
        }
    }
}
