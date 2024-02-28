using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nastepnaKaczka
{
    internal class Bird
    {
        public string Name { get; set; }
        public virtual void Fly(string destination)
        {
            Console.WriteLine($"{this} leci do {destination}");
        }

        public override string ToString()
        {
            return $"Ptak {Name}";    
        }
        
        public static void FlyAway(List<Bird> flock, string destination)
        {
            foreach(Bird bird in flock) 
            {
                bird.Fly(destination);
            }
        }
    }
}
