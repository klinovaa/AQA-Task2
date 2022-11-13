using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace Homework7
{
    public class Cat : Animal
    {
        public string Color { get; set; }
        public bool isDomestic;
        public Person person;
        private int speed;

        public Cat() : base()
        {
        }

        public Cat(string kind, int age, int speed, string color, bool isDomestic)
            : base(kind, age, speed)
        {
            Color = color;
            this.isDomestic = isDomestic;
        }

        public override int Speed 
        {
            get => speed;
            set
            {
                if (value < 30 && value > 0)
                    speed = value;
            }
        }

        public override void OvercomeDistance(int time)
        {
            Console.WriteLine($"Cat ran {Speed * time} km for day");
        }

        public override void Speak()
        {
            Console.WriteLine("Cat meows");
        }

        public void MiceAreCaught(int miceValue)
        {
            if (miceValue == 0)
            {
                Console.WriteLine("Null mices were caught today");
            }
            else
            {
                Console.WriteLine($"{miceValue} mice are caught today");
            }
        }

        public void PersonForCat(Person person)
        {
            if (!isDomestic)
            {
                this.person = person;
                Console.WriteLine($"{person.FirstName}{person.LastName} loves to pet his cat!");
            }
        }
    }
}
