using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiLo
{
    internal class HiLoGame
    {
        public const int MAXIMUM = 10;
        private static Random random = new Random();
        private static int currentNumber = random.Next(1, MAXIMUM + 1);
        private static int pot = 10;
        public static int GetPot() { return pot; }

        public static void Guess(bool higher)
        {
            int nextNumber = random.Next(1, MAXIMUM + 1);
            if (higher && nextNumber >= currentNumber || !higher && nextNumber <= currentNumber)
            {
                Console.WriteLine("GG zgadles nigga");
                pot++;
            }
            else
            {
                Console.WriteLine("rest in peace you wont be missed");
                pot--;
            }
            currentNumber = nextNumber;
            Console.WriteLine($"Kolejna liczba to: {currentNumber}");
        }

        public static void Hint()
        {
            int half = MAXIMUM / 2;
            if(currentNumber >= half)
            {
                Console.WriteLine($"Liczba wynosi conajmniej {half}");
            }
            else
            {
                Console.WriteLine($"Liczba jest mniejsza niż {half}");
            }
            pot--;
        }
    }

    
}
