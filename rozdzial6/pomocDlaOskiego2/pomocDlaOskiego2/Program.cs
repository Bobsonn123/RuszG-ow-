namespace pomocDlaOskiego2
{
    internal class Program
    {

        static Random randomRoll = new Random();
        static void Main(string[] args)
        {
            SwordDamage swordDamage = new SwordDamage(RollDice(3));
            ArrowDamage arrowDamage = new ArrowDamage(RollDice(1));
            while (true)
            {
                Console.Write("0 - ani magiczny, ani płonący; 1 - magiczny; 2 - płonący; 3 - magiczny i płonący; inne wartości - koniec: ");
                char keyChar = Console.ReadKey().KeyChar;

                if (keyChar != '0' && keyChar != '1' && keyChar != '2' && keyChar != '3') return;

                Console.Write("\nM - miecz, S - strzały, inne znaki - koniec");
                char weaponKey = Char.ToUpper(Console.ReadKey().KeyChar);

                switch(weaponKey)
                {
                    case 'M':
                        swordDamage.Roll = RollDice(3);
                        swordDamage.Magic = (keyChar == '1' || keyChar == '3');
                        swordDamage.Flaming = (keyChar == '2' || keyChar == '3');
                        Console.WriteLine($"\nRzut: {swordDamage.Roll}, punkty obrażeń: " + $"{swordDamage.Damage}\n");
                        break;
                    case 'S':
                        arrowDamage.Roll = RollDice(1);
                        arrowDamage.Magic = (keyChar == '1' || keyChar == '3');
                        arrowDamage.Flaming = (keyChar == '2' || keyChar == '3');
                        Console.WriteLine($"\nRzut: {arrowDamage.Roll}, punkty obrażeń: " + $"{arrowDamage.Damage}\n");
                        break;
                    default:
                        return;
                    
                }


                

            }
        }
        private static int RollDice(int numberOfRolls)
        {
            int total = 0;
            for (int i = 0; i < numberOfRolls; i++) total += randomRoll.Next(1, 7);
            return total;
        }
    }

}
