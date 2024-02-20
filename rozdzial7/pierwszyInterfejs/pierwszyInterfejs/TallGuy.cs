using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pierwszyInterfejs
{
    internal class TallGuy : IClown
    {
        public string Name;
        public int Height;

        public string FunnyThingIHave { get { return "wielkie buty"; } }

        public void Honk()
        {
            Console.WriteLine("Bip, bip!");
        }
        public void TalkAboutYourself(){
            Console.WriteLine($"Nazywam się {Name}. Mam {Height} cm wzrostu.");
        }
    }
}
