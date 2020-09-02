using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD6502_Assignment1Part1_QiangZhang2173138
{
    class Program
    {
        static void Main(string[] args)
        {
            String temp;
            int pNumber;
            int houseScores = 0;
            String chooseAgain;
            int[] cardScores = new int[13] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 };
            String[] str = new String[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "ACE" };

            do
            {
                Game game = new Game();

                Console.Write("Welcome to Blackjack");
                Console.Write("How many players(1-7)?");
                temp = Console.ReadLine();
                pNumber = int.Parse(temp);
                game.startGame(pNumber);

                foreach (var item in game.players)
                {
                    if (item.isHouse == false)
                    {
                        Console.WriteLine();
                        Console.Write(item.playerName + ": ");
                        foreach (var c in item.totalCard)
                        {
                            Console.Write(str[(int)c.cardValue] + " " + (c.cardShape).ToString() + " ");
                        }
                        Console.Write(" -> " + item.totalScore);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Write(item.playerName + ": ");
                        int p = 0;
                        // if(item.totalScore == 21)
                        foreach (var c in item.totalCard)
                        {
                            if (p == 0)
                            {
                                Console.Write("XX ");
                            }
                            else
                            {
                                Console.Write(str[(int)c.cardValue] + " " + (c.cardShape).ToString() + " ");
                            }
                            p++;
                        }
                        Console.WriteLine();
                    }
                }

                String choose;
                foreach (var item in game.players)
                {
                    if (!item.isHouse)
                    {
                        choose = "y";
                        Console.WriteLine(item.playerName + " do you want card(y or n)?");
                        choose = Console.ReadLine();
                        while (item.totalScore <= 21 && choose == "y")
                        {
                            if (choose == "y")
                            {
                                var cardsPlayer = item.dealCard();
                                item.totalCard.Add(cardsPlayer);
                                item.totalScore = 0;

                                foreach (var newitem in item.totalCard)
                                {
                                    if (cardScores[(int)newitem.cardValue] == 11 && item.totalScore + cardScores[(int)newitem.cardValue] > 21)
                                    {
                                        cardScores[(int)newitem.cardValue] = 1;
                                    }
                                    item.totalScore += cardScores[(int)newitem.cardValue];
                                }

                                Console.WriteLine();
                                Console.Write(item.playerName + ": ");

                                foreach (var c in item.totalCard)
                                {
                                    Console.Write(str[(int)c.cardValue] + " " + (c.cardShape).ToString() + " ");
                                }
                                Console.Write(" -> " + item.totalScore);
                                Console.WriteLine();
                            }
                            else
                            {
                                break;
                            }
                            if (item.totalScore > 21)
                            {
                                break;
                            }
                            Console.WriteLine(item.playerName + " do you want card(y or n)?");
                            choose = Console.ReadLine();
                        }
                    }
                    else
                    {
                        int t = 0;
                        while (item.totalScore < 16)
                        {
                            var cardsPlayer = item.dealCard();
                            item.totalCard.Add(cardsPlayer);
                            item.totalScore = 0;

                            foreach (var newitem in item.totalCard)
                            {
                                if (cardScores[(int)newitem.cardValue] == 11 && item.totalScore + cardScores[(int)newitem.cardValue] > 21)
                                {
                                    cardScores[(int)newitem.cardValue] = 1;
                                }
                                item.totalScore += cardScores[(int)newitem.cardValue];
                            }

                            Console.WriteLine();
                            Console.Write(item.playerName + ": ");
                            foreach (var c in item.totalCard)
                            {
                                Console.Write(str[(int)c.cardValue] + " " + (c.cardShape).ToString() + " ");
                            }
                            Console.Write(" -> " + item.totalScore);
                            houseScores = item.totalScore;
                            t = 1;
                            if (item.totalScore > 21)
                            {
                                Console.Write(" -> bust!");
                            }
                            Console.WriteLine();

                            if (item.totalScore > 21)
                            {
                                break;
                            }
                        }

                        if (t == 0)
                        {
                            Console.Write(item.playerName + ": ");
                            foreach (var c in item.totalCard)
                            {
                                Console.Write(str[(int)c.cardValue] + " " + (c.cardShape).ToString() + " ");
                            }
                            Console.Write(" -> " + item.totalScore);
                            Console.WriteLine();
                        }

                    }
                }


                foreach (var item in game.players)
                {
                    if (!item.isHouse)
                    {
                        if (item.totalScore > 21)
                        {
                            Console.WriteLine(item.playerName + " ->  Loses!");
                        }
                        else if (houseScores > 21)
                        {
                            Console.WriteLine(item.playerName + " ->  Wins!");
                        }
                        else if (item.totalScore > houseScores)
                        {
                            Console.WriteLine(item.playerName + " ->  Wins!");
                        }
                        else if (item.totalScore == houseScores)
                        {
                            Console.WriteLine(item.playerName + " -> Ties!");
                        }
                        else if (item.totalScore < houseScores)
                        {
                            Console.WriteLine(item.playerName + " -> Loses!");
                        }
                    }
                }

                Console.WriteLine("Do you want to continue playing?(y/n)");
                chooseAgain = Console.ReadLine();
            } while (chooseAgain == "y");
        }
    }
}
