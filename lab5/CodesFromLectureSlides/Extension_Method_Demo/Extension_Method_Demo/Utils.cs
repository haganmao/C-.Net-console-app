using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method_Demo
{
   public static class Utils
    {
        public static bool Is_Palindrome(this String s)
        {
            StringBuilder forward = new StringBuilder();
            StringBuilder reverse = new StringBuilder();

            foreach (char c in s)
            {
                if (char.IsLetter(c))
                {
                    forward.Append(char.ToUpper(c));
                    reverse.Insert(0, char.ToUpper(c));
                    Console.WriteLine(" \n" + c);
                    Console.WriteLine(" "+ reverse);
                }
            }

            String forward_string = forward.ToString();
            String reverse_string = reverse.ToString();

            return forward_string == reverse_string;


        }
    }
}
