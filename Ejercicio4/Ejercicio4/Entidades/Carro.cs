using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Entidades
{
    internal class Carro : Entity
    {
        public String Placa { get; private set;}

        public Carro (string modelo,string color, string marca, string placa) : base(modelo,color, marca)
        {
            Placa = placa;
        }

    }
}
