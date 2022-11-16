using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    public class Dolphin : Animal
    {
        public bool isInZoo;
        private int speed;

        public Dolphin() : base()
        {
        }

        public Dolphin(string kind, int age, int speed, bool isInZoo)
            : base(kind, age, speed)
        {
            this.isInZoo = isInZoo;
        }

        public override int Speed
        {
            get => speed; 
            set
            {
                if (value < 60 && value > 0)
                    speed = value;
            }
        }

        public void GetHomeForDolphin()
        {
            if (!isInZoo)
            {
                Console.WriteLine("Dolphin is happy, he's free!");
            }
            else
            {
                Console.WriteLine("Dolphin is sad, he lives in zoo :(");
            }

        }

        public override void OvercomeDistance(int time)
        {
            Console.WriteLine($"Dolphin swam {Speed * time} km for day");
        }

        public override void Speak()
        {
            Console.WriteLine("Dolphin chirps");
        }
    }
}
