using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zlodziejSejfKonsola
{
    internal class JewelThief : Locksmith
    {
        private string stolenJewels;
        protected override void ReturnContents(string safeContents, SafeOwner owner)
        {
            stolenJewels = safeContents;
            Console.WriteLine($"Kradnę kosztowności! Ukradłem: {stolenJewels}");
        }
    }
}
