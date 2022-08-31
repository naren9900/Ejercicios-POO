using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Entidades
{
    internal class Moto : Entity
    {
        public int CantidadLlantas { get; protected set;}

        public Moto(string Modelo, string color, string marca, int cantidadLlantas): base(Modelo, color, marca)
        {
            CantidadLlantas = cantidadLlantas;
        }
    }
}
