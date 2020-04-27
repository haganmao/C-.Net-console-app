using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace SD6502_Assignment1Part2_Task2a_QiangZhang2173138
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new Stopwatch();
            var firstname = new List<string>();
            var lastname = new List<string>();
            var email = new List<string>();
            string csvfile = Environment.CurrentDirectory;
            var getpath = Directory.GetParent(csvfile).Parent.FullName;
            var path = getpath+@"\datafile\unsorted_data.csv";

            if (!File.Exists(path))
            {
                Console.WriteLine(path);
                Console.WriteLine("File not found, Check path");
                Console.ReadLine();
            }

            using (var read = new StreamReader(path))
            {
                while (!read.EndOfStream)
                {
                    var splits = read.ReadLine().Split(',');
                    firstname.Add(splits[0]);
                    lastname.Add(splits[1]);
                }
            }
            var ArrayFirstname = firstname.ToArray();
            var ArrayLastname = lastname.ToArray();


            while (true)
            {
                Console.WriteLine("Please Enter LastName for Search: ");
                string searchname = Console.ReadLine();

                watch.Reset();
                watch.Start();
                bool c=SeqSearch(ArrayLastname, searchname);
                if (c)
                {
                    Console.WriteLine("This student in the list");
                }
                else
                    Console.WriteLine("This student not in the list");
                watch.Stop();
                Console.WriteLine($"Sequential Search Execution Time: {watch.ElapsedTicks} Ticks\n");
            }
        }

        static bool SeqSearch(string[] arr, string sValue)
        {
            for (int index = 0; index < arr.Length-1 ; index++)
            {
                if (arr[index] == sValue)
                    return true;
            }
            return false;
        }
    }
}

