using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaryaKlinavaSaysHello
{
    public class Luggage
    {
        private int weight;

        public string Name { get; set; }

        public string Description { get; set; }

        public int Weight
        {
            get => weight;
            set
            {
                if (value > 20)
                {
                    throw new CustomException(value);
                }
                else
                {
                    weight = value;
                }
            }
        }

        public Luggage (string name, string description, int weight)
        {
            Name = name;
            Description = description;
            Weight = weight;
        }
    }
}
