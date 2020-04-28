using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

namespace SD6502_Assignment1Part2Task2b_QiangZhang2173138
{
    class Program
    {
        static void Main(string[] args)
        {

            var watch = new Stopwatch();
            var firstname = new List<string>();
            var lastname = new List<string>();
            string yesContinue;
            var email = new List<string>();
            var getpath = AppDomain.CurrentDomain.BaseDirectory;
            getpath = getpath.Remove(getpath.IndexOf(@"\bin\"));
            var path =getpath+@"\datafile\sorted_data.csv";

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


            do
            {
                Console.WriteLine("Please Enter LastName for Search: ");
                string searchname = Console.ReadLine();
                watch.Reset();
                watch.Start();
                int index = Array.BinarySearch(ArrayLastname, searchname);
                ShowWhere(ArrayLastname, index);
                watch.Stop();
                Console.WriteLine($"Binary Search Execution Time: {watch.ElapsedTicks} Ticks\n");

                Console.WriteLine("\nDo you want to continue? (y/n)");
                yesContinue = Console.ReadLine();
            } while (yesContinue == "y");
        }

        private static void ShowWhere<T>(T[] array, int index)
        {
            if (index < 0)
            {
                index = ~index;
                Console.Write("This student not in the list.\n");
            }
            else
            {
                Console.WriteLine("This student in the list.\n");
            }
        }
    }
}




