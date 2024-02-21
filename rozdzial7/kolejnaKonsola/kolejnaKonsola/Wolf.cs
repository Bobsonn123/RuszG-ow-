using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolejnaKonsola
{
    internal class Wolf : Canine, IPackHunter
    {
        public Wolf(bool belongsToPack) 
        {
            BelongsToPack = belongsToPack;
        }
        public override void MakeNoise()
        {
            if (BelongsToPack)
            {
                Console.WriteLine("Należę do stada");
            }
            Console.WriteLine("Auuuuuu!");
        }

        public void HuntInPack()
        {
            if (BelongsToPack) 
                Console.WriteLine("Idę polować z moim stadem!");
            else
                Console.WriteLine("Nie należę do stada...");
        }
    }
}
