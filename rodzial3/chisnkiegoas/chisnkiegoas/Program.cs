namespace chisnkiegoas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = 0.75;
            Guy player = new Guy() { Cash = 100, Name = "gracz"};

            

            while(player.Cash > 0)
            {
                player.WriteMyInfo();
                Console.Write("Podaj stawkę: ");
                string howMuch = Console.ReadLine();


                if (int.TryParse(howMuch, out int amount))
            {
                int pot = player.GiveCash(amount) * 2;

                if(pot > 0)
                    {
                        if(random.NextDouble() > odds)
                        {
                            int winnings = pot;
                            Console.WriteLine(winnings + " to twoja wygrana");
                            player.RecieveCash(winnings);
                        }
                        else
                        {
                            Console.WriteLine("loser");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("wpisz poprawna liczbe");
                }
            }
            Console.WriteLine("kasyno always win nigga");
        }
    }
}
