using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio4.Entidades;

namespace Ejercicio4.Fabricas
{
    internal interface IFactory
    {
        public Entity BuildCar(string modelo, string Color, string marca, string placa);
        public Entity BuilMotorcycle(string modelo, string color, string marca, int cantidadLlantas);
    }
}
