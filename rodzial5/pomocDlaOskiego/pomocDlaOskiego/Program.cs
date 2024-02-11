namespace pomocDlaOskiego
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomRoll = new Random();
            SwordDamage sword = new SwordDamage();
            while (true)
            {
                Console.Write("0 - ani magiczny, ani płonący; 1 - magiczny; 2 - płonący; 3 - magiczny i płonący; inne wartości - koniec: ");
                char keyChar = Console.ReadKey().KeyChar;

                if (keyChar != '0' && keyChar != '1' && keyChar != '2' && keyChar != '3') return;
                int roll = randomRoll.Next(1,7) + randomRoll.Next(1, 7) + randomRoll.Next(1, 7);
                sword.Roll = roll;
                sword.SetMagic(keyChar == '1' || keyChar == '3');
                sword.SetFlaming(keyChar == '2' || keyChar == '3');
                Console.WriteLine("\nRzut: " + sword.Roll + ", punkty obrażeń: " + sword.Damage + "\n");

            }

        }
    }
}
