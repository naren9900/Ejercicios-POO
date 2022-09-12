using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio1MVC.Model;
using Ejercicio1MVC.Control;


namespace Ejercicio1MVC.View.Boos
{
    internal class CrearBoss : IVista<Boss>
    {
        public void Render(Boss obj)
        {
            Console.WriteLine($"Felicitaciones se a creado la clase jefe, su nombre es {obj.Name} y du documento es {obj.DocumentName} ");
        }
    }
}
