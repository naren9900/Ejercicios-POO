using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    internal class Herbivoro:Animal
    {
        public string TipoHerbiboro { get; protected set; }
        public Herbivoro(string raza, string color, string tipoHerbiboro) : base(raza, color)
        {
            TipoHerbiboro = tipoHerbiboro;
        }

        public override string Alimentacion()
        {
            var mostrar = "";
            if (this.TipoHerbiboro.ToLower() == "frugivoros")
            {
                mostrar = "Los animales frugivoros son aquellos que se alimentar de frutas";
            }
            else if(this.TipoHerbiboro.ToLower() == "fitofagos")
            {
                mostrar = "Son aquellos que se alimenta de hierbas";
            }

            return mostrar;
        }
    }
}
