using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    public abstract class Technic
    {
        public string? ModelName { get; }
        public decimal Price { get; }
        public abstract string Description { get; }
        public Technic(string? modelName, decimal price)
        {
            ModelName = modelName;
            Price = price;
        }

        public abstract void TurnOn();

        public abstract void TurnOff();
    }
}
