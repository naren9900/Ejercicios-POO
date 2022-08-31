using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Entidades
{
    internal abstract class Entity
    {
        public string Modelo { get; protected set;}
        public string Color { get; protected set; }
        public string Marca { get; protected set; }

        public Entity(string modelo, string color, string marca)
        {
            Modelo = modelo;
            Color = color;
            Marca = marca;
        }

        public string Arrancar()
        {
            return " El vehiculo esta arrancando";
        }
    }
}
