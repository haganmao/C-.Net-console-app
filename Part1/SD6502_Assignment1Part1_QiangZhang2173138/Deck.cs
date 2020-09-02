using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD6502_Assignment1Part1_QiangZhang2173138
{
    class Deck : Card
    {
        public List<Deck> allCard = new List<Deck>();

        public Deck()
        {
        }

        public Deck(suit cs, rank cv) : base(cs, cv)
        {
        }

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

        public void shuffle()
        {
            Random random = new Random();
            for (int i = allCard.Count - 1; i > 0; i--)
            {
                int index = random.Next(0, i);
                Deck temp = allCard[i];
                allCard[i] = allCard[index];
                allCard[index] = temp;
            }
        }

        public Card dealCard()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            Deck deck = new Deck();

            deck.createDeck();
            deck.shuffle();

            int cardIndexOne = random.Next(0, deck.allCard.Count);

            Card cardOne = new Card
            {
                cardShape = deck.allCard[cardIndexOne].cardShape,
                cardValue = deck.allCard[cardIndexOne].cardValue
            };

            deck.allCard.RemoveAt(cardIndexOne);
            return cardOne;
        }
    }
}
