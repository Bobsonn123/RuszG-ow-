using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pierwszyInterfejs
{
    internal interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }
        void ScareLittleChildren();

        void ScareAdults()
        {
            Console.WriteLine($@"JEstem pradawnym złem prześladującym Cię we snach. Spójrz na mój przerażający naszyjnik z {random.Next(1, 4)} palcami moich ofiar.
            A, byłbym zapomniał...");
            ScareLittleChildren();
        }
    }
}
