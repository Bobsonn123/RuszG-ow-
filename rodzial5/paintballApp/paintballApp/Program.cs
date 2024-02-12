
namespace paintballApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numberOfBalls = ReadInt(20, "Liczba kulek");
            int magazineSize = ReadInt(16, "Pojemność magazynka");

            Console.Write($"Załadowany [false]: ");
            bool.TryParse(Console.ReadLine(), out bool isLoaded);

            PaintballGun gun = new PaintballGun(numberOfBalls,  magazineSize, isLoaded);
            while (true) 
            {
                Console.WriteLine($"Kulki: {gun.Balls}, załadowano: {gun.BallsLoaded}");
                if (gun.isEmpty()) Console.WriteLine("OSTRZEŻENIE: brak amunicji");
                Console.WriteLine("Spacja - strzał, p - przeładowanie, " + "+ - dodaj amunicje, k - koniec");
                char key = Console.ReadKey(true).KeyChar;
                if (key == ' ') Console.WriteLine($"Próba stzału: {gun.Shoot()}");
                else if (key == 'p') gun.Reload();
                else if (key == '+') gun.Balls += gun.MagazineSize;
                else if (key == 'k') return;
            }
        }

         static int ReadInt(int lastUsedValue, string prompt)
        {
            Console.Write(prompt + " [" + lastUsedValue + "] ");
            string answer = Console.ReadLine();

            if(int.TryParse(answer, out int num) )
            {
                Console.WriteLine("użycie wartości: " + num);
                return num;
            } 
            {
                Console.WriteLine("uzycie wartosci domyslnej: " + lastUsedValue);
                return lastUsedValue;
            }
        }
    }
}
