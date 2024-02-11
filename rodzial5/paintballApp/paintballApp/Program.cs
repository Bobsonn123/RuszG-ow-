namespace paintballApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaintballGun gun = new PaintballGun();
            while (true) 
            {
                Console.WriteLine($"Kulki: {gun.Balls}, załadowano: {gun.GetBallsLoaded()}");
                if (gun.isEmpty()) Console.WriteLine("OSTRZEŻENIE: brak amunicji");
                Console.WriteLine("Spacja - strzał, p - przeładowanie, " + "+ - dodaj amunicje, k - koniec");
                char key = Console.ReadKey(true).KeyChar;
                if (key == ' ') Console.WriteLine($"Próba stzału: {gun.Shoot()}");
                else if (key == 'p') gun.Reload();
                else if (key == '+') gun.Balls += PaintballGun.MAGAZINE_SIZE;
                else if (key == 'k') return;
            }
        }
    }
}
