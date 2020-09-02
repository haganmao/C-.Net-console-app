using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD6502_Assignment1Part1_QiangZhang2173138
{
    class Player : Game
    {
        public int playerNumber;
        public String houseName = "House";

        public List<Card> tCard = new List<Card>();

        public Player()
        {
        }

        public Player(String plName, int plNumbers, List<Card> cardS, int tScore, bool isH) : base(plName, plNumbers, cardS, tScore, isH)
        {
            tCard = cardS;
        }

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
