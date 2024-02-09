namespace zklasaelephant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant lucek = new Elephant() {Name = "lucek", earSize = 80};
            Elephant laura = new Elephant() {Name = "laura", earSize = 180};


            while (true)
            {

                Console.WriteLine("Napisz liczbe, 1 aby przedstawic lucka, 2 zeby przedstawic laure, a 3 zeby ich przestawic");
                char keyChar = Console.ReadKey(true).KeyChar;
                Console.WriteLine("wcisnales " + keyChar);
                if (keyChar == '1')
                {
                    lucek.WhoAmI();
                }
                else if (keyChar == '2')
                {
                    laura.WhoAmI();
                }
                else if (keyChar == '3')
                {
                    Elephant holder;
                    holder = lucek;
                    lucek = laura;
                    laura = holder;
                    Console.WriteLine("referencje przestawione");

                }
                else if (keyChar == '4')
                {
                    laura.SpeakTo(lucek, "cześć, Lucku!");
                }


            }

        }
    }
}
