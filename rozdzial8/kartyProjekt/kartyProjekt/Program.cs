namespace kartyProjekt
{
    internal class Program
    {

        private static Random random = new Random();
        static void Main(string[] args)
        {
            Card randomCard = new Card ((Value)random.Next(1, 14), (Suit)random.Next(4));

            Console.WriteLine(randomCard.Name);
        }
    }
}
