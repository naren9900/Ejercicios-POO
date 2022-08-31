using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    internal class Carnivoro : Animal
    {
        public int cantidadGarra { get; protected set;}
        public int CantidadColmillos { get; protected set;}
        public Carnivoro(String raza, string color, int cantidadGarra, int cantidadColmillos) : base(raza,color)
        {
            this.cantidadGarra = cantidadGarra;
            CantidadColmillos = cantidadColmillos;
        }

        public override string Alimentacion()
        {
            return "son aquellos que se alimenta de otros carnivoros";
        }
    }
}
