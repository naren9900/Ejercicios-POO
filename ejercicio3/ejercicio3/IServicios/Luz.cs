using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3.IServicios
{
    internal class Luz : IServicio
    {
        public void Abrir()
        {
            Console.WriteLine("presional el interruptor de la luz");
        }
    }
}
