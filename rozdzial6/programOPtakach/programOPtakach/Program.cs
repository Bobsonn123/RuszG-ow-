﻿namespace programOPtakach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Bird bird;
                Console.Write("\nWciśnij G (gołąb) lub S (struś): ");
                char key = Char.ToUpper(Console.ReadKey().KeyChar);
                if (key == 'G') bird = new Pigeon();
                else if (key == 'S') bird = new Ostrich();
                else return;
                Console.Write("\nIle jaj składa ptak? ");
                if (!int.TryParse(Console.ReadLine(), out int numberOfEggs)) return;
                Egg[] eggs = bird.LayEggs(numberOfEggs);
                foreach (Egg egg in eggs)
                {
                    Console.WriteLine(egg.Description);
                }
            }
        }
    }
}
