using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolejnaKonsola
{
    internal class Hippo : Animal, ISwimmer
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Chrząkanie");
        }

        public void Swim()
        {
            Console.WriteLine("Plusk! Idę popływać");
        }
    }
}
