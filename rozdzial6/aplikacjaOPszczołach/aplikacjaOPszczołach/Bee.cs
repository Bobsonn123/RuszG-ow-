using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace aplikacjaOPszczołach
{
    internal class Bee
    {

        public string Job { get; private set; }
        
        public Bee(string job) 
        {
            Job = job;
        }
        public virtual float CostPerShift { get; }

        public virtual void WorkTheNextShift()
        {
            if(HoneyVault.ConsumeHoney(CostPerShift))
            {
                DoJob();
            }
        }

        public virtual void DoJob()
        {
            // przeslanianie przez inne klasy
        }

    }
}
