using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1MVC.Model
{
    public class HardWorking : Entity
    {
        public string Name { get; protected set; }

        public string DocumentName { get; protected set; }

        public List<BossHardWorking> BossHardWorkings { get; private set; }

        public Company Company { get; private set; }


        public HardWorking(string id, string name, string documentName, Company company) : base(id)
        {
            Name = name;
            DocumentName = documentName;
            BossHardWorkings = new List<BossHardWorking>();
            Company = company;
        }

        public static HardWorking Build(string id, string name, string documentName, Company company)
        {
            return new HardWorking(id, name, documentName, company);
        }

        public void AddBoss(string bossID)
        {
            this.BossHardWorkings.Add(new BossHardWorking(Guid.NewGuid().ToString(), bossID, this.Id));
        }

    }
}
