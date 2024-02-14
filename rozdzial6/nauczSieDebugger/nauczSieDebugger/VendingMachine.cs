using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace nauczSieDebugger
{
    internal class VendingMachine
    {
        public virtual string Item { get; }
        protected virtual bool CheckAmount(decimal money)
        {
            return false;
        }
        public string Dispense(decimal money)
        {
            if (CheckAmount(money)) return Item;
            else return "Wrzuć odpowiednią kwotę";
        }
    }
}
