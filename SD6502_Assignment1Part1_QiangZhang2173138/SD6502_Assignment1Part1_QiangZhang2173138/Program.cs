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
            Console.WriteLine("Welcome to the Blackjack");
            Console.WriteLine("How many players(1-7)? ");
            int numberofplayer = int.Parse(Console.ReadLine());
            string[] playerlist = new string[numberofplayer];
            for (int i = 0; i < playerlist.Length; i++)
            {
                Console.WriteLine("Enter player name: ");
                playerlist[i] = Console.ReadLine();
            }


            Console.WriteLine("The name of playerlist are:");

            foreach (string name in playerlist)
            {

                Console.WriteLine(name);

            }
            Console.ReadLine();


        }
    }
}
