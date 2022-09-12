using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1MVC.Model
{
    public abstract class Entity
    {
        public string Id { get; protected set; }

        protected Entity(string id)
        {
            Id = id;
        }
    }
}
