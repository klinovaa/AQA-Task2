using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    public class Ship : ITransportable, ISwimmable
    {
        public string Cargo { get; set; }

        public string Direction { 
            get 
            { 
                return "Swim in appropriate direction to deliver cargo"; 
            }
        }

        public void Swim()
        {
            Console.WriteLine("Starting the engine");
        }

        public void TransportCargo()
        {
            Console.WriteLine($"Cargo '{Cargo}' is transported to appropriate destination");
        }
    }
}
