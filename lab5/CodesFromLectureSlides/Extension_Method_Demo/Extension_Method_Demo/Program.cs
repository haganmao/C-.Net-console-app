using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this program determines whether strings that you have typed is palindrome ");

            while (true)
            {
                Console.WriteLine("\n\nType a sentence.");
                String s = Console.ReadLine();
                if (s.Is_Palindrome())
                {
                    Console.WriteLine(@" + s + @"" is a palindrome");
                }
                else
                {
                    Console.WriteLine(@"""" + s + @""" is not a palindrome");
                }
            }

            Console.ReadLine();


        }
    }
}
