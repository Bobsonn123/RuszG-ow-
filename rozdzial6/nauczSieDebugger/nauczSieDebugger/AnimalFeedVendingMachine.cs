using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nauczSieDebugger
{
    internal class AnimalFeedVendingMachine : VendingMachine
    {
        public override string Item
        {
            get { return "Garść karmy dla zwierząt"; }
        }

        protected override bool CheckAmount(decimal money)
        {
            return money >= 1.25M;
        }
    }
}
