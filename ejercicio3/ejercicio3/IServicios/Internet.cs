using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3.IServicios
{
    internal class Internet : IServicio
    {
        public void Abrir()
        {
            Console.WriteLine("Conectar el Model e ingresar contraseña");
        }
    }
}
