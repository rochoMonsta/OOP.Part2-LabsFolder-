using System;
using System.Collections.Generic;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Input&Sorting
            var sorting = new Sorting();

            Console.Write("Enter count of stones: ");
            var countOfStones = Int32.Parse(Console.ReadLine());

            Stone[] stonesArray = new Stone[countOfStones];

            EnterStonesToArray(stonesArray);
            PrintArray(stonesArray);

            Console.WriteLine("\nSorting by InsertionSort:");
            sorting.InsertionSort(stonesArray);
            PrintArray(stonesArray);

            //Console.WriteLine("\nSorting by MergeSort:");
            //sorting.MergeSort(stonesArray, 0, stonesArray.Length - 1);
            //PrintArray(stonesArray);
            #endregion
            List<Stone> stones1 = new List<Stone>();
            List<Stone> stones2 = new List<Stone>();

            GetResult(stonesArray, stones1, stones2);

            var stonesArray1 = stones1.ToArray();
            var stonesArray2 = stones2.ToArray();

            Console.WriteLine("First group:");
            PrintArray(stonesArray1);
            Console.WriteLine("Second group:");
            PrintArray(stonesArray2);

            Console.ReadLine();
        }
        public static void EnterStonesToArray (Stone[] array)
        {
            string name = "";
            int weight = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                Console.WriteLine($"Enter info for {i + 1} stone:");
                Console.Write($"\tEnter stone name: ");
                name = Console.ReadLine();
                Console.Write($"\tEnter ({name}) - stone weight: ");
                weight = Int32.Parse(Console.ReadLine());

                var stone = new Stone(name, weight);
                array[i] = stone;
            }
            Console.Clear();
        }
        public static void PrintArray <T>(T[] array)
        {
            foreach (var element in array)
                Console.WriteLine("\t" + element);
        }
        public static void GetResult(Stone[] array, List<Stone> stones1, List<Stone> stones2)
        {
            int sum1 = 0;
            int sum2 = 0;
            for (int i = array.Length - 1; i >= 0; --i)
            {
                sum1 = 0;
                sum2 = 0;
                stones1.Clear();
                stones2.Clear();
                for (int j = array.Length - 1; j >= i; --j)
                {
                    sum1 += array[j].StoneWeight;
                    stones1.Add(array[j]);
                }
                for (int k = 0; k < i; ++k)
                {
                    sum2 += array[k].StoneWeight;
                    stones2.Add(array[k]);
                }
                if (Math.Abs(sum2 / sum1) < 2)
                {
                    Console.WriteLine("You can");
                    Console.WriteLine($"First group: {sum1}; Second group: {sum2}\n");
                    break;
                }
                Console.WriteLine("You can't");
                Console.WriteLine($"First group: {sum1}; Second group: {sum2}\n");
            }
        }
    }
}
