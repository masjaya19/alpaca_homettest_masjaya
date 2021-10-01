using System;
using System.Collections.Generic;
using System.Linq;

namespace alpaca_homettest_masjaya
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Display the array in numerical order");
            //Display the array in numerical order
            int[] array1 = { 1, 2, 2, 3, 4, 5, 6, 7, 5, 6, 7, 8, 9, 10, 12, 1, 23, 4, 54, 4, 67, 19, 10 };
            Array.Sort(array1);
            foreach (int i in array1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("Find and print out all duplicates");

            //Find and print out all duplicates
            var list = new Dictionary<int, int>();
            foreach (var dup in array1 )
            {
                if (list.ContainsKey(dup))
                    list[dup]++;
                else
                    list[dup] = 1;

            }
            foreach (var val in list)
                Console.WriteLine("{0} occured {1} time", val.Key, val.Value);

            Console.WriteLine();
            Console.WriteLine("Print out all missing numbers in sequence");

            //Print out all missing numbers in sequence (so between 1-67, print out all numbers missing from the above array) in numerical order
            List<int> myList = new List<int>(array1);
            Console.WriteLine("Numbers... ");
            foreach (int val in myList)
            {
                Console.WriteLine(val);
            }
            int a = myList.OrderBy(x => x).First();
            int b = myList.OrderBy(x => x).Last();
            List<int> myList2 = Enumerable.Range(a, b - a + 1).ToList();
            List<int> remaining = myList2.Except(myList).ToList();
            Console.WriteLine("Remaining numbers... ");
            foreach (int res in remaining)
            {
                Console.WriteLine(res);
            }
        }
    }
}
