using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programOPtakach
{
    internal class BrokenEgg : Egg
    {
        public BrokenEgg(string color) : base(0, $"{color} pęknięte")

        {
            Console.WriteLine("Ptak złożył pęknięte jajo");
        }
    }
}
