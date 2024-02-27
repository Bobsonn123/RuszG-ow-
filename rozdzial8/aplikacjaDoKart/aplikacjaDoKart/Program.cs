namespace aplikacjaDoKart
{
    internal class Program
    {

        static Random random = new Random();

        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();

            Console.Write("Podaj liczbę kart: ");
            string answer = Console.ReadLine();

            if(int.TryParse(answer, out int times)) 
            {
                for(int i = 0; i < times; i++)
                {
                    cards.Add(RandomCard());
                }
            }
            PrintCards(cards);

            Console.WriteLine("\nsortowanie kart\n");

            cards.Sort(new CardComparerByValue());

            PrintCards(cards);
        }
        static Card RandomCard()
        {
            return new Card((Values)random.Next(1, 14), (Suits)random.Next(1, 4));
        }

        static void PrintCards(List<Card> cards)
        {
            foreach(Card card in cards)
            {
                Console.WriteLine(card.Name);
            }
        }
    }
}
