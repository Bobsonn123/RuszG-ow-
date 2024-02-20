using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace aplikacjaOPszczołach
{
    abstract class Bee : IWorker
    {

        public string Job { get; private set; }
        
        public Bee(string job) 
        {
            Job = job;
        }
        public abstract float CostPerShift { get; }

        public virtual void WorkTheNextShift()
        {
            if(HoneyVault.ConsumeHoney(CostPerShift))
            {
                DoJob();
            }
        }

        protected abstract void DoJob();

    }
}
