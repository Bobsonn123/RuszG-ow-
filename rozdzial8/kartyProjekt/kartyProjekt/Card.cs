using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartyProjekt
{
    internal class Card
    {

        public Suit Suit { get; private set; }
        public Value Value { get; private set; }

        
        public Card(Value value, Suit suit) 
        {
            this.Suit = suit;
            this.Value = value;
        }

        public string Name { get { return $"{Value} {Suit}"; } }


    }
}
