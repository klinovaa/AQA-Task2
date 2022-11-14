using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    public interface ITransportable
    {
        public static int maxWeight = 5000;
        public static int maxWidth = 50;
        public static int maxLenght = 500;

        public string Cargo { get; set; }

        public void Distance(int time)
        {
        }

        public void TransportCargo();

    }
}
