namespace drwalNalesniki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Queue<Lumberjack> lumberjacks = new Queue<Lumberjack>();  

            Console.Write("Imię pierwszego drwala: ");
            string name;

            while ((name = Console.ReadLine()) != "")
            {
                Console.Write("Liczba naleśników: ");
                string liczba = Console.ReadLine();

                if (int.TryParse(liczba, out int nalesniki))
                {
                    Lumberjack lumberjack = new Lumberjack(name);

                    for(int i = 0; i < nalesniki; i++) lumberjack.TakeFlapjack((Flapjack)random.Next(1, 4));

                    lumberjacks.Enqueue(lumberjack);
                }
                Console.Write("Imię następnego drwala (pusty wiersz, aby zakończyć): ");
            }

            foreach (Lumberjack lumberjack in lumberjacks)
            {
                lumberjack.EatFlapjacks();
            }
        }
    }
}
