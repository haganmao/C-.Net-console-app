using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame_Mao
{
    class Deck : Card
    {

        //all card list for 52 cards  
        public List<Deck> allCard = new List<Deck>();

        public Deck()
        {
        }

        public Deck(suit cs, rank cv) : base(cs, cv)
        {

        }

        //Create One Deck
        public List<Deck> createDeck()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    allCard.Add(new Deck((suit)i, (rank)j));
                }
            }
            return allCard;
        }

        //Shuffle deck，Random index，swap position
        public void shuffle()
        {
            Random random = new Random();
            for (int i = allCard.Count - 1; i > 0; i--)
            {
                //get random index
                int index = random.Next(0, i);
                //swap
                Deck temp = allCard[i];
                allCard[i] = allCard[index];
                allCard[index] = temp;
            }
        }


        
        //deal one card
        public Card dealCard()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            Deck deck = new Deck();

            deck.createDeck();
            deck.shuffle();


            //Random get index
            int cardIndexOne = random.Next(0, deck.allCard.Count);

            //Create an new card
            Card cardOne = new Card
            {
                cardShape = deck.allCard[cardIndexOne].cardShape,
                cardValue = deck.allCard[cardIndexOne].cardValue
            };

            //remove the card in order to get same value card at short time.
            deck.allCard.RemoveAt(cardIndexOne);
            return cardOne;
        }
    }
}
