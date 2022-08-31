using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class Vehiculo
    {
        public string Modelo { get; protected set;}
        public string Marca { get; protected set; }
        public string Color { get; protected set; }

        public Vehiculo(string modelo, string marca, string color)
        {
            Modelo = modelo;
            Marca = marca;
            Color = color;
        }

        public string Acelerar()
        {
            return "El vehiculo esta acelerando";
        }
        protected string Frenar()
        {
            return "El vehiculo va ha frenar";
        }
    }
}
