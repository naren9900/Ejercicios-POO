using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1MVC.Model
{
    public class Boss : Entity
    {
        public string Name { get; private set; }

        public string DocumentName { get; private set; }

        public Company Company { get; private set; }

        public List<BossHardWorking> bossHardWorkings { get; private set; }

        public Boss(string id, string name, string documentName, Company company) : base(id)
        {
            Name = name;
            DocumentName = documentName;
            bossHardWorkings = new List<BossHardWorking>();
            Company = company;
        }

        public static Boss Build(string id, string name, string documentName, Company company)
        {
            return new Boss(id, name, documentName, company);
        }

        public void AddHardWorking(string hardWorkingID)
        {
            this.bossHardWorkings.Add(new BossHardWorking(Guid.NewGuid().ToString(), hardWorkingID, this.Id));
        }
    }
}
