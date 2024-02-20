namespace pierwszyInterfejs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TallGuy tallGuy = new TallGuy() { Height = 183, Name = "Jeremi" };
            tallGuy.TalkAboutYourself();
            Console.WriteLine($"Ten wysoki gość ma {tallGuy.FunnyThingIHave}.");
            tallGuy.Honk();
        }
    }
}
