using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACTORY.entities
{
    internal class Entities
    {
        public int Id { get; protected set; }

        protected Entities(int id)
        {
            Id = id;
        }
    }
}
