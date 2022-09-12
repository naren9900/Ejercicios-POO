using FACTORY.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACTORY.fabricas
{
    internal class Factory:IFactory
    {
        public Entities BuildEstudiante(int id)
        {
            return new Estudiante(id);
        }
        public Entities BuildProfesor(int id, String ingreso)
        {
            return new Profesor(id, ingreso);
        }
    }
}
