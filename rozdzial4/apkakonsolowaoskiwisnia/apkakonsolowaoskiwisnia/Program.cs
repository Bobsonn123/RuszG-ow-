
namespace apkakonsolowaoskiwisnia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbilityScoreCalculator calculator = new AbilityScoreCalculator();
            while (true)
            {
                calculator.RollResult = ReadInt(calculator.RollResult, "Początkowy rzut 4d6");
                calculator.DivideBy = ReadDouble(calculator.DivideBy, "Dzielone przez");
                calculator.AddAmount = ReadInt(calculator.AddAmount, "Dodawana wartość");
                calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");
                calculator.CalculateAbilityScore();
                Console.WriteLine("Oblicznone pumkty umiejętności: " + calculator.Score);
                Console.WriteLine("Wciśnij Q, by zakończyć, lub inny klawisz, aby kontynuować");
                char keyChar = Console.ReadKey(true).KeyChar;
                if (keyChar == 'Q' || keyChar == 'q') return;
            }
        }

        private static double ReadDouble(double lastUsedValue, string prompt)
        {
            // Wyświetlanie informacji i [wartości domyślnej]
            
            // Wczytywanie wiersza danych wyjściowych i używanie int.TryParse do próby
            Console.Write(prompt + " [" + lastUsedValue + "]: ");
            string reader = Console.ReadLine();

            if (double.TryParse(reader, out double value))
            {


                Console.WriteLine("  Uzycie wartości: " + value);
                return value;

            }
            else
            {
                Console.WriteLine("  Uzycie wartości: " + lastUsedValue);
                return lastUsedValue;
            }
            // ich przetworzenia. Jeśli to możliwe, wyświetlanie w konsoli
            // " użycie wartości " + value, W przeciwnym razie wyświetlanie w konsoli
            // " użycie wartości podstawowej " + lastUsedValue.
        }
        /// <summary>
        /// Wyświetla informację i wczytuje wartość typu int z konsoli.
        /// </summary>
        /// <param name="lastUsedValue">Wartość domyślna</param>
        /// <param name="prompt">Informacja wyświetlona w konsoli</param>
        /// <returns>Wczytana wartość int lub wartość domyślna
        /// (jeśli nie można przetworzyć wczytanej wartości</returns>
        /// <exception cref="NotImplementedException"></exception>
        private static int ReadInt(int lastUsedValue, string prompt)
        {
            // Wyświetlanie informacji i [wartości domyślnej]

            // Wczytywanie wiersza danych wyjściowych i używanie int.TryParse do próby
            Console.Write(prompt + " [" + lastUsedValue + "]: ");
            string reader = Console.ReadLine();

            if (int.TryParse(reader, out int value))
            {


                Console.WriteLine("  Uzycie wartości: " + value);
                return value;

            }
            else
            {
                Console.WriteLine("  Uzycie wartości: " + lastUsedValue);
                return lastUsedValue;
            }
            // ich przetworzenia. Jeśli to możliwe, wyświetlanie w konsoli
            // " użycie wartości " + value, W przeciwnym razie wyświetlanie w konsoli
            // " użycie wartości podstawowej " + lastUsedValue.
        }
    }
}
