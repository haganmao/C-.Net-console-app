using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SD6502_Assignment1Part2_Task4_QiangZhang2173138
{
    class Program
    {
        static void Main(string[] args)
        {
            string yesContinue;
            string csvfile = Environment.CurrentDirectory;
            var path = Directory.GetParent(csvfile).Parent.FullName;
            var validcasespath = path+@"\datafile\TestInputsOutputs-(validcases).txt";
            var invalidcasespath = path + @"\datafile\TestInputsOutputs-(Invalidcases).txt";


            do
            {
                Console.WriteLine("\nPlease select 1 or 2: ");
                Console.WriteLine("1. Read valid Cases Display all in lower case.");
                Console.WriteLine("2. Read invalid Cases Indicate what is wrong");

                string menu = Console.ReadLine();
                string intmenu = menu;
                switch (intmenu)
                {
                    case "1":
                        if (!File.Exists(validcasespath))
                        {
                            Console.WriteLine("File not found, Check path");
                            Console.ReadLine();
                        }
                        string[] validcasesemailAddress = System.IO.File.ReadAllLines(validcasespath);
                        var validArrayEmailAddress = validcasesemailAddress.ToArray();
                        validArrayEmailAddress = Array.ConvertAll(validArrayEmailAddress, c => c.ToLower());
                        for (int i = 0; i < validArrayEmailAddress.Length; i++)
                        {
                            validArrayEmailAddress[i] = validArrayEmailAddress[i].Replace("_at_", "@").Replace("_dot_", ".");
                        }

                        foreach (string address in validArrayEmailAddress)
                        {
                            Console.WriteLine(address);
                        }
                        break;

                    case "2":
                        if (!File.Exists(invalidcasespath))
                        {
                            Console.WriteLine("File not found, Check path");
                            Console.ReadLine();
                        }
                        string[] invalidcasesemailAddress = System.IO.File.ReadAllLines(invalidcasespath);
                        var invalidArrayEmailAddress = invalidcasesemailAddress.ToArray();
                        invalidArrayEmailAddress = Array.ConvertAll(invalidArrayEmailAddress, d => d.ToLower());
                        for (int i = 0; i < invalidArrayEmailAddress.Length; i++)
                        {
                            invalidArrayEmailAddress[i] = invalidArrayEmailAddress[i].Replace("_at_", "@").Replace("_dot_", ".");
                        }
                        foreach (string formattedEmailAddress in invalidArrayEmailAddress)
                        {
                            if (emailchecker(formattedEmailAddress))
                                return;
                        }
                        break;
                }
                Console.WriteLine("\nDo you want to continue? (y/n)");
                yesContinue = Console.ReadLine();
            } while (yesContinue == "y") ;
        }


        public static bool emailchecker(string email)
        {

            if (email.LastIndexOf('@') != email.IndexOf('@'))
                Console.WriteLine(email + " ***** More than one @ symbol");
            if (email.Contains("#") || email.Contains("*")|| email.Contains("&"))
                Console.WriteLine(email + " ***** Contains invalid character");
            else if (email.IndexOf('@') ==-1)
                Console.WriteLine(email + " ***** Not a Email address");
            else
            {
                string username = email.Split('@')[0];
                string domain = email.Split('@')[1];
                if (username.LastIndexOf('-') != username.IndexOf('-'))
                    Console.WriteLine(email + " ***** More than one - symbol in the user name");
                if (username.LastIndexOf('_') != username.IndexOf('_'))
                    Console.WriteLine(email + " ***** More than one _ symbol in the user name");
                if (username.LastIndexOf('.') != username.IndexOf('.'))
                    Console.WriteLine(email + " ***** More than one . symbol in the user name");
                if (email.LastIndexOf('-') == email.IndexOf('.')+1)
                    Console.WriteLine(email + " ***** Part begins with separator");
                if (email.LastIndexOf('.') == email.IndexOf('_')+1)
                    Console.WriteLine(email + " ***** Part ends with separator");
                if (username.IndexOf(' ') == 0)
                    Console.WriteLine(email + " ***** Leading space");
                if (username.IndexOf('.')-1 == domain.IndexOf('.') - 1)
                    Console.WriteLine(email + " ***** Trailing space");
                if (username.IndexOf('.') == 0)
                    Console.WriteLine(email + " ***** Leading dot");
                else if (domain.LastIndexOf(' ') > domain.IndexOf('['))
                    Console.WriteLine(email + " ***** Internal space");
                else if (domain.Contains(".co.nz")) { }
                else if (domain.Contains(".com.au")) { }
                else if (domain.Contains(".co.ca")) { }
                else if (domain.Contains(".co.us")) { }
                else if (domain.Contains(".co.uk")) { }
                else if (domain.IndexOf('[') < domain.IndexOf(']')) { }
            }
            return false;
        }
    }
}


