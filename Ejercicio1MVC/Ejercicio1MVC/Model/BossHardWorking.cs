using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1MVC.Model
{
    public class BossHardWorking : Entity
    {
        public String BossID { get; protected set; }

        public String HardWorkingID { get; protected set; }


        public BossHardWorking(string id, string bossID, string hardWorkingID) : base(id)
        {
            BossID = bossID;
            HardWorkingID = hardWorkingID;
        }
    }
}
