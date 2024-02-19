using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplikacjaOPszczołach
{
    internal class NectarCollector : Bee
    {
        public NectarCollector() : base("Zbieraczka nektaru") { }

        public override float CostPerShift { get { return 1.95f; } }
        public const float NECTAR_COLLECTED_PER_SHIFT = 33.25f;

        public override void DoJob()
        {
            HoneyVault.CollectNectar(NECTAR_COLLECTED_PER_SHIFT);
        }
    }
}
