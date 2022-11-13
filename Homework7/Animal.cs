using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    public abstract class Animal
    {
        public string kind;
        public int Age { get; set; }
        public abstract int Speed { get; set; }

        public Animal() : this ("Unknown", 0, 0)
        {
        }

        public Animal (string kind, int age, int speed)
        {
            this.kind = kind;
            Age = age;
            Speed = speed;
        }

        public void Eat()
        {
            Console.WriteLine("The animal eats!");
        }

        public abstract void Speak();

        public abstract void OvercomeDistance(int hours);
    }
}
