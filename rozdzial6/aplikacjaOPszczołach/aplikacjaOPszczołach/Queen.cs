using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplikacjaOPszczołach
{
    internal class Queen : Bee
    {
        public Queen() : base("Królowa")
        {
            AssignBee("Producentka miodu");
            AssignBee("Opiekunka jaj");
            AssignBee("Zbieraczka nektaru");
        }

        private IWorker[] workers = new IWorker[0];

        private float eggs = 2;
        private float unassignedWorkers = 3;
        public string StatusReport { get; private set; }
        public const float EGGS_PER_SHIFT = 0.45f;
        public const float HONEY_PER_UNASSIGNED_WORKER = 0.5f;
        

        public override float CostPerShift { get { return 2.15f; } }

        protected override void DoJob()
        {
            eggs += EGGS_PER_SHIFT;
            foreach (IWorker worker in workers)
            {
                worker.WorkTheNextShift();
                
            }
            HoneyVault.ConsumeHoney(HONEY_PER_UNASSIGNED_WORKER * unassignedWorkers);
            UpdateStatusReport();
        }

        public void AssignBee(string job)
        {
            switch (job)
            {
                case "Opiekunka jaj":
                    AddWorker(new EggCare(this));
                    break;
                case "Producentka miodu":
                    AddWorker(new HoneyManufacturer());
                    break;
                case "Zbieraczka nektaru":
                    AddWorker(new NectarCollector());
                    break;

            }
            UpdateStatusReport();
        }

        private void AddWorker (IWorker worker)
        {
            if(unassignedWorkers >= 1)
            {
                unassignedWorkers--;
                Array.Resize(ref workers, workers.Length + 1);
                workers[workers.Length-1] = worker;
            }
        }

        public void CareForEggs(float eggsToConvert)
        {
            if(eggs >= eggsToConvert)
            {
                eggs -= eggsToConvert;
                unassignedWorkers += eggsToConvert;
            } 
                
        }

        private void UpdateStatusReport()
        {
            StatusReport = $"Raport o stanie skarbca:\n{HoneyVault.StatusReport}\n" + 
            $"\nLiczba jaj: {eggs:0.0}\n" + $"Nieprzydzielone robotnice: {unassignedWorkers:0.0}" +
            $"\n{WorkerStatus("Zbieraczka nektaru")}\n{WorkerStatus("Producentka miodu")}" +
            $"\n{WorkerStatus("Opiekunka jaj")}\nROBOTNIE W SUMIE: {workers.Length}";
        }

        private string WorkerStatus(string job)
        {
            int count = 0;
            foreach(IWorker worker in workers)
            {
                if (worker.Job == job) count++;
            }
            return $"{job}: {count}";
        }


    }
}
