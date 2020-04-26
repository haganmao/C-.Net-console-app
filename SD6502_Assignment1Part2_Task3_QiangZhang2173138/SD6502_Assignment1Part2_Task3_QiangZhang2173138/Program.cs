using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;


namespace SD6502_Assignment1Part2_Task3_QiangZhang2173138
{
    class Program
    {
        static void Main(string[] args)
        {

            var watch = Stopwatch.StartNew();           
            var firstname = new List<string>();
            var lastname = new List<string>();
            var email = new List<string>();
            var path = @"D:\Studying T1 2020\SD6502 Programming II\Assignment1\SD6502_Assignment1Part2_Task3_QiangZhang2173138\datafile\unsorted_data.csv";

            if (!File.Exists(path))
            {
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

                Console.WriteLine("Please select which sorting algorithm: ");
                Console.WriteLine("1. Insertion Sort");
                Console.WriteLine("2. Buble Sort");
                Console.WriteLine("3. Qucik Sort");

                string menu = Console.ReadLine();
                string intmenu = menu;
                switch (intmenu)
                {
                    case "1":

                        var elapsedMs1 = watch.ElapsedMilliseconds;
                        watch.Reset();
                        watch.Start();
                        InsertSort(ArrayFirstname);
                        foreach (var FirstnameInsertionSort in ArrayFirstname)
                        {
                            Console.WriteLine(FirstnameInsertionSort);
                        }
                        watch.Stop();
                        Console.WriteLine($"Insertion Short Execution Time: {watch.ElapsedTicks} Ticks\n");
                        Console.WriteLine("Test other aligorithm please press enter");
                        Console.ReadLine();
                        break;
                    case "2":
                        var elapsedMs2 = watch.ElapsedMilliseconds;
                        watch.Reset();
                        watch.Start();
                        bubblesort(ArrayFirstname);
                        foreach (var FirstnameBubbleSort in ArrayFirstname)
                        {
                            Console.WriteLine(FirstnameBubbleSort);
                        }
                        watch.Stop();
                        Console.WriteLine($"Bubble Short Execution Time: {watch.ElapsedTicks} Ticks\n");
                        Console.WriteLine("Test other aligorithm please press enter");
                        Console.ReadLine();
                        break;

                    case "3":
                        var elapsedMs3 = watch.ElapsedMilliseconds;
                        watch.Reset();
                        watch.Start();
                        quickSort(ArrayFirstname, 1, ArrayFirstname.Length - 1);
                        foreach (var FirstnameQuickSort in ArrayFirstname)
                        {
                            Console.WriteLine(FirstnameQuickSort);
                        }
                        watch.Stop();
                        Console.WriteLine($"Quick Short Execution Time: {watch.ElapsedTicks} Ticks\n");
                        Console.WriteLine("Test other aligorithm please press enter");
                        Console.ReadLine();
                        break;
             }
            }
            
        }

        static void InsertSort(IComparable[] list)
        {
            int i, j;

            for (i = 2; i < list.Length; i++)
            {
                IComparable value = list[i];
                j = i - 1;
                while ((j >= 0) && (list[j].CompareTo(value) > 0))
                {
                    list[j + 1] = list[j];
                    j--;
                }
                list[j + 1] = value;
            }
        }
        static void bubblesort(string[] array)
        {
            string temp;
            bool swap;
            do
            {
                swap = false;
                for (int i = 1; i < (array.Length - 1); i++)
                {
                    if (string.Compare(array[i], array[i + 1]) > 0)
                    {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swap = true;
                    }
                }
            } while (swap == true);

        }

        static void quickSort(string[] list, int start, int stop)
        {
            if (start >= stop)
                return;
            int pivotIndex = (start + stop) / 2;

            swapReferences(list, pivotIndex, start);
            IComparable pivot = list[start];

            int i, j = start;

            for (i = start + 1; i <= stop; i++)
            {
                if (list[i].CompareTo(pivot) <= 0)
                {
                    j++;
                    swapReferences(list, i, j);
                }
            }

            swapReferences(list, start, j);
            quickSort(list, start, j - 1);
            quickSort(list, j + 1, stop);

        }
        static void swapReferences(string[] a, int index1, int index2)
        {
            string tmp = a[index1];
            a[index1] = a[index2];
            a[index2] = tmp;
        }
    }
}

