using System.Collections.Generic;

namespace nowaKaczka
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IComparer<Duck> sizeComparer = new DuckComparerByKind();
            List<Duck> ducks = new List<Duck>()
            {
                new Duck() {Kind = KindOfDuck.krzyżówka, Size = 43},
                new Duck() {Kind = KindOfDuck.piżmowa, Size = 45},
                new Duck() {Kind = KindOfDuck.nur, Size = 35},
                new Duck() {Kind = KindOfDuck.piżmowa, Size = 27},
                new Duck() {Kind = KindOfDuck.krzyżówka, Size = 35},
                new Duck() {Kind = KindOfDuck.nur, Size = 33},
            };
            ducks.Sort(sizeComparer);
            PrintDucks(ducks);
        }

        public static void PrintDucks(List<Duck> ducks)
        {
            foreach(Duck duck in ducks)
            {
                Console.WriteLine($"{duck.Kind}, {duck.Size} cm");
            }    
        }
    }
}
