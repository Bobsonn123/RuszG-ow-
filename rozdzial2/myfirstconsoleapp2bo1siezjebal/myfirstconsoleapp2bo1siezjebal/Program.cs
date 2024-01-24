using System;

namespace myfirstconsoleapp2bo1siezjebal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TryAnIf();
            TrySomeLoops();
            TryAnIfElse();
        }

        private static void TryAnIfElse()
        {
            int x = 5;
            if(x == 10)
            {
                Console.WriteLine("x musi być równe 10");

            }
            else
            {
                Console.WriteLine("x nie równa się 10");
            }
        }

        private static void TrySomeLoops()
        {
            int count = 0;

            while(count < 10) 
            {
                count = count + 1;
            }

            for (int i = 0; i < 5; i++)
            {
                count = count - 1;
            }
            Console.WriteLine("Wynik to " + count);
        }

        private static void TryAnIf()
        {
            int someValue = 4;
            string name = "Bobbo Junior";
            if((someValue == 3) && (name == "Jasiek"))
            {
                Console.WriteLine("x równa się 3 ,a name równa się jasiek");
            }
            Console.WriteLine("Ten wiersz jest wykonywany zawsze");
        }
    }
}