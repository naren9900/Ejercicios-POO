using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3.IServicios
{
    internal class Agua : IServicio
    {
        public void Abrir()
        {
            Console.WriteLine("Abrir la llave del agua");
        }
    }
}
