using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programOPtakach
{
    internal class Bird
    {
        public static Random Randomizer = new Random();
        public virtual Egg[] LayEggs(int numberOfEggs)
        {
            Console.Error.WriteLine("Metoda Bird.LayEggs nie powinna być wywołana");
            return new Egg[0];
        }
    }
}
