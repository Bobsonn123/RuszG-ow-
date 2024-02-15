using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programOPtakach
{
    internal class Pigeon : Bird
    {
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];

            for (int i = 0; i < eggs.Length; i++)
            {
                if (Bird.Randomizer.Next(4) == 0)
                {
                    eggs[i] = new BrokenEgg("Białe");
                }
                else
                {
                    eggs[i] = new Egg(Bird.Randomizer.Next(4) * 2 + 1, "Białe");
                }
            }
            return eggs;
        }
    }
}
