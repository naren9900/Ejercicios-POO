using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio4.Entidades;


namespace Ejercicio4.Fabricas
{
    internal class Factory : IFactory
    {
        public Entity BuildCar (string modelo, string Color, string marca, string placa)
        {
            return new Carro(modelo, Color, marca, placa);
        }

        public Entity BuilMotorcycle(string modelo, string color, string marca, int cantidadLlantas)
        {
            return new Moto(modelo, color, marca, cantidadLlantas);
        }
    }
}
