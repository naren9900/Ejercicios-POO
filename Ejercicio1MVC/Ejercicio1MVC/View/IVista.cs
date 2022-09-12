using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio1MVC.Model;

namespace Ejercicio1MVC.View
{
    public interface IVista<T> where T: Entity
    {
        public void Render(T obj);
    }
}
