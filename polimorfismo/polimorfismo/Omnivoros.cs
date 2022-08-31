using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    internal class Omnivoros:Animal
    {
        public Omnivoros(string raza, string color) : base(raza, color){}
        public override string Alimentacion()
        {
            return "Son aquellos animales que se alimenta de carne como tambien de plantas como lo son los monos, zorros";
        }
    }
}
