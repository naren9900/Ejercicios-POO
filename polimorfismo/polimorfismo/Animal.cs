using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    internal abstract class Animal
    {
        public string Raza { get; protected set; }
        public string Color { get; protected set; }

        public Animal(string raza, string color)
        {
            Raza = raza;
            Color = color;
        }

        public abstract string Alimentacion();
    }

    
}
