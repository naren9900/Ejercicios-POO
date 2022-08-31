using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3.espacios
{
    internal class Baño : Lugar
    {
        public Baño(string metrosCuadrados) : base(metrosCuadrados)
        {
        }

        public override string Limpiar()
        {
            return "lavar el baño con desinfectante";
        }
    }
}
