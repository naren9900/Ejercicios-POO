using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3.espacios
{
    internal class Cocina : Lugar
    {
        public Cocina(string metrosCuadrados) : base(metrosCuadrados){}

        public override string Limpiar()
        {
            return "Limpiar con Clorox y  Jabón en polvo el piso y muebles ";
        }
    }
}
