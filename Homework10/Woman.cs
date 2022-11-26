using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    public class Woman : Human
    {
        public Woman() : this("No name", "woman")
        {
        }

        public Woman(string name, string surname) : base(name, surname)
        {
        }
    }
}
