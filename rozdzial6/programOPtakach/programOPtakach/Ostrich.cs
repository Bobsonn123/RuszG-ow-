﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programOPtakach
{
    internal class Ostrich : Bird
    {
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];

            for (int i = 0; i < eggs.Length; i++)
            {
                eggs[i] = new Egg(Randomizer.NextDouble() + 12, "Nakrapiane");
            }
            return eggs;
        }
    }
}
