using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    public interface ISwimmable
    {
        public static int minSpeed = 1;
        public static int maxSpeed = 1500;

        public string Direction { get; }

        public void Distance (int time)
        {
        }

        public void Swim();
    }
}
