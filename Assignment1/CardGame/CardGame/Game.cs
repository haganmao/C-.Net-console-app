using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    class Game : Deck
    {
        public String playerName;

        public int playerNumbers;
        public String temp;

        public bool isHouse;

        public int totalScore;
        public List<Card> totalCard = new List<Card>();
        public List<Game> players = new List<Game>();


        //default constructor
        public Game() { }


        //game constructor
        public Game(String plName, int plNumbers, List<Card> cardS, int tScore, bool isH)
        {
            playerName = plName;
            playerNumbers = plNumbers;
            totalCard = cardS;
            totalScore = tScore;
            isHouse = isH;
        }



        //Methods
        //Start Game
        public void startGame(int totalPlayerNumber)
        {
            int[] cardScores = new int[13] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 };

            do
            {
                if (totalPlayerNumber <= 0 || totalPlayerNumber > 7)
                {
                    Console.Write("player number must between 1~7, How many players(1-7)?");
                    temp = Console.ReadLine();
                    totalPlayerNumber = int.Parse(temp);
                    continue;
                }
                for (int i = 0; i < totalPlayerNumber; i++)
                {
                    Player player = new Player();
                    Console.Write("Plese Enter the player name: ");
                    player.setPlayerName = Console.ReadLine();
                    player.setPlayernumber = i + 1;
                    var cardsPlayer = player.dealCard();
                    player.totalCard.Add(cardsPlayer);
                    cardsPlayer = player.dealCard();
                    player.totalCard.Add(cardsPlayer);
                    player.totalScore = 0;
                    player.isHouse = false;

                    foreach (var item in player.totalCard)
                    {

                        // Console.Write();
                        if (cardScores[(int)item.cardValue] == 11 && player.totalScore + cardScores[(int)item.cardValue] > 21)
                        {
                            cardScores[(int)item.cardValue] = 1;
                        }
                        player.totalScore += cardScores[(int)item.cardValue];
                    }
                    // Console.WriteLine(player.totalScore);
                    players.Add(new Game(player.playerName, player.setPlayernumber, player.totalCard, player.totalScore, player.isHouse));

                }

                Player house = new Player();
                house.setPlayerName = house.houseName;
                house.setPlayernumber = totalPlayerNumber + 1;
                var cardsHouse = house.dealCard();
                house.totalCard.Add(cardsHouse);
                cardsHouse = house.dealCard();
                house.totalCard.Add(cardsHouse);
                house.totalScore = 0;
                house.isHouse = true;

                foreach (var item in house.totalCard)
                {

                    // Console.Write();
                    if (cardScores[(int)item.cardValue] == 11 && house.totalScore + cardScores[(int)item.cardValue] > 21)
                    {
                        cardScores[(int)item.cardValue] = 1;
                    }
                    house.totalScore += cardScores[(int)item.cardValue];
                }
                // Console.WriteLine(player.totalScore);
                players.Add(new Game(house.playerName, house.setPlayernumber, house.totalCard, house.totalScore, house.isHouse));
                break;
            } while (true);
        }


    }
}
