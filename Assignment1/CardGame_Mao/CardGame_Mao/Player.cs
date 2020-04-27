using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame_Mao
{
    class Player : Game
    {
        public int playerNumber;
        public String houseName = "House";

        public List<Card> tCard = new List<Card>();


        //default constructor
        public Player() { }


        //player constructor
        public Player(String plName, int plNumbers, List<Card> cardS, int tScore, bool isH) : base(plName, plNumbers, cardS, tScore, isH)
        {
            tCard = cardS;
        }


        //property
        public String setPlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        public int setPlayernumber
        {
            get { return playerNumber; }
            set
            {
                playerNumber = value;
            }
        }
        public List<Card> GetCards
        {
            get { return tCard; }
        }
        public String setHouseName
        {
            get { return houseName; }
        }
    }
}
