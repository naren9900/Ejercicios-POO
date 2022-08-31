using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3.espacios
{
    internal abstract class Lugar
    {
        public string MetrosCuadrados { get; protected set; }

        public Lugar(string metrosCuadrados)
        {
            this.MetrosCuadrados = metrosCuadrados;
        }

        public string MostrarMetrosCuadrados()
        {
            return "La cantidad de metros cuadrados " + this.MetrosCuadrados;
        }
        public abstract string Limpiar();
    }
}
