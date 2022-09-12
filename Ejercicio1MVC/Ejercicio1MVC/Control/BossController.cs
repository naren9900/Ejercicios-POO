using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio1MVC.Model;
using Ejercicio1MVC.View;

namespace Ejercicio1MVC.Control
{
    internal class BossController
    {
        private IVista <Boss> vista;

        public BossController(IVista<Boss> vista)
        {
            this.vista = vista;
        }

        public void Crear(string id, string name, string documentName, Company company)
        {
            Boss boss;
            boss = Boss.Build(id, name, documentName,company);
            this.vista.Render(boss);
        }
    }
}
