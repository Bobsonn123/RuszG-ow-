using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zlodziejSejfKonsola
{
    internal class SafeOwner
    {
        private string valuables = "";
        public void RecieveContents(string safeContents)
        {
            valuables = safeContents;
            Console.WriteLine($"Moje {valuables}! Dziękuje za zwrot!");
        }
    }
}
