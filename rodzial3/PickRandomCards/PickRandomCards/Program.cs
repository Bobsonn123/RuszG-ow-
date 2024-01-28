namespace PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wpisz liczbe generowanych kart: ");
            string line = Console.ReadLine();

            if(int.TryParse(line, out int numberOfCards)) 
            {
                CardPicker.PickSomeCards(numberOfCards);
                foreach (string schylek in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(schylek);
                }
            }
            else { Console.WriteLine("not right my boy"); }
        }
    }
}
