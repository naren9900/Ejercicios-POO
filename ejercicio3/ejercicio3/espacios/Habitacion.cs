using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3.espacios
{
    internal class Habitacion : Lugar
    {
        public Habitacion(string metrosCuadrados) : base(metrosCuadrados){}

        public override string Limpiar()
        {
            return "Barrer y trapear, recoger los zapatos y ropa";
        }
    }
}
