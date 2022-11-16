using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    internal class Truck : ITransportable
    {

        public string Cargo { get; set; }

        public void TransportCargo()
        {
            Console.WriteLine($"Trucks cargo '{Cargo}' is transported to appropriate destination");
        }

        public void StartEngine()
        {
            Console.WriteLine("Engine is started");
        }
    }
}
