using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaryaKlinavaSaysHello
{
    public class CustomException : Exception
    {
        private int weight;

        public CustomException(int weight)
            : base($"Inappropriate weight for luggage - {weight}. It should be less than 20 kg!")
        {
            this.weight = weight;
        }
    }
}
