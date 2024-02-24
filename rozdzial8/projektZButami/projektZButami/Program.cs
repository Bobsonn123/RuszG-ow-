using System;
using System.Collections.Generic;
using System.Linq;

namespace projektZButami
{
    internal class Program
    {
        static ShoeCloset shoeCloset = new ShoeCloset();
        static void Main(string[] args)
        {
            while (true)
            {
                shoeCloset.PrintShoes();
                Console.Write("\nWciśnij 'd', aby dodać, lub 'u' aby usunąć buty: ");
                char key = Console.ReadKey().KeyChar;


                switch (Char.ToLower(key))
                {
                    case 'd':
                        shoeCloset.AddShoe();
                        break;
                    case 'u':
                        shoeCloset.RemoveShoe();
                        break;
                    default:
                        return;1uu

                }
            }
        }
    }
}
