using System.ComponentModel.Design;

namespace komkkh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guy jacek = new Guy() {Cash = 50, Name = "Jacek" };
            Guy bartek = new Guy() {Cash = 100, Name = "Bartek" };

            while (true) 
            {
                jacek.WriteMyInfo();
                bartek.WriteMyInfo();

                Console.Write("Podaj kwote: ");
                string howMuch = Console.ReadLine();
                if (howMuch == "") return;
                if(int.TryParse(howMuch, out int amount))
                {
                    Console.WriteLine("Pieniądze ma przekazać: ");
                    string whichGuy = Console.ReadLine();

                    if (whichGuy.ToLower() == "jacek")
                    {
                        jacek.GiveCash(amount);
                        bartek.RecieveCash(amount);
                    }
                    else if (whichGuy.ToLower() == "bartek")
                    {
                        bartek.GiveCash(amount);
                        jacek.RecieveCash(amount);
                    }
                    else
                    {
                        Console.WriteLine("Wpisz 'bartek' lub 'jacek'");
                    }
                   
                }
                else
                {
                    Console.WriteLine("Wpisz kworte (lub pusty wiersz) aby zakonczyc");
                }
            }
        }
    }
}
