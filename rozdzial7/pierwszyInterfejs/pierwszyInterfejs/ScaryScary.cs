using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pierwszyInterfejs
{
    internal class ScaryScary : FunnyFunny, IScaryClown
    {
        private readonly int scaryThingCount;

        public string ScaryThingIHave { get { return $"pająki - {scaryThingCount}"; } }

        public ScaryScary(int scaryThingCount, string funnyThing) : base(funnyThing)
        {
            this.scaryThingCount = scaryThingCount;
        }

        public void ScareLittleChildren()
        {
            Console.WriteLine($"Ha! Mam was! Zobaczcie moje {ScaryThingIHave}");
        }
    }
}
