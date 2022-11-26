using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    public class Man : Human
    {
        public Man() : this("No name", "man")
        {
        }

        public Man(string name, string surname) : base(name, surname)
        {
        }
    }
}
