using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1MVC.Model
{
    public class Company : Entity
    {
        public string Address { get; private set; }

        public string Sector { get; private set; }

        public int NIT { get; private set; }

        public List<HardWorking> HardWorking { get; private set; }

        public Company(string id, string address, string sector, int nit) : base(id)
        {
            Address = address;
            Sector = sector;
            NIT = nit;
            HardWorking = new List<HardWorking>();
        }

        public static Company Build(string id, string address, string sector, int nit)
        {
            return new Company(id, address, sector, nit);
        }

        public void AddHardWorking(HardWorking hardWorking)
        {
            this.HardWorking.Add(hardWorking);
        }

    }
}
