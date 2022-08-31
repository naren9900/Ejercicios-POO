using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3.espacios
{
    internal class Patio : Lugar
    {
        public Patio(string metrosCuadrados) : base(metrosCuadrados){}

        public override string Limpiar()
        {
            throw new NotImplementedException();
        }
    }
}
