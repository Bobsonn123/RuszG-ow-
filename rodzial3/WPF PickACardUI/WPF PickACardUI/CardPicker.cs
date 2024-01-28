using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACardUI
{
    internal class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];

            for(int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            int value = random.Next(1, 5);

            if (value == 1) return "pik";
            if (value == 2) return "kier";
            if (value == 3) return "trefl";
            return "karo";
        }

        private static string RandomValue()
        {
            // od jeden do 14
            int value = random.Next(1, 14);
            // jezeli liczba to 1 to wtedy asa zwraca
            if (value == 1) return "As";
            //jezeli liczba to 11 to zwraca jopasa
            if (value == 11) return "Walet";
            //jezeli liczba to 12 to dama
            if (value == 12) return "Dama";
            //jezeli liczba to 13 to krool
            if (value == 13) return "Król";
            //jezeli liczba to od 2 do 10 to zwraca tą liczbe w postaci string
            return value.ToString();
        }
    }
}
