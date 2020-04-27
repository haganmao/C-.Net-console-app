using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame_Mao
{
    class Card
    {

        public suit cardShape;
        public rank cardValue;

        public enum suit { Spade, Heart, Diamond, Club }
        public enum rank { TWO = 0, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, J, Q, K, Ace }


        //defaut constructor
        public Card() { }

        //constructor
        public Card(suit cs, rank cv)
        {
            cardShape = cs;
            cardValue = cv;
        }


        //methods
        //accessor
        public rank Rank { get; set; }
        public suit Suit { get; set; }

    }
}
