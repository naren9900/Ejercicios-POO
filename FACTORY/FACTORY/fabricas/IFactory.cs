using FACTORY.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACTORY.fabricas
{
    internal interface IFactory
    {
        public Entities BuildEstudiante(int id);
        public Entities BuildProfesor(int id, string Ingreso);
    }
}
