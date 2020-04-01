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

            List<Stone> stonesArray = new List<Stone>();

            EnterStonesToArray(stonesArray, countOfStones);
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


            Console.WriteLine("First group:");
            PrintArray(stones1);
            Console.WriteLine("Second group:");
            PrintArray(stones2);

            Console.ReadLine();
        }
        public static void EnterStonesToArray (List<Stone> array, int count)
        {
            string name = "";
            int weight = 0;
            for (int i = 0; i < count; ++i)
            {
                Console.WriteLine($"Enter info for {i + 1} stone:");
                Console.Write($"\tEnter stone name: ");
                name = Console.ReadLine();
                Console.Write($"\tEnter ({name}) - stone weight: ");
                weight = Int32.Parse(Console.ReadLine());

                var stone = new Stone(name, weight);
                array.Add(stone);
            }
            Console.Clear();
        }
        public static void PrintArray <T>(List<T> array)
        {
            foreach (var element in array)
                Console.WriteLine("\t" + element);
        }
        public static void GetResult(List<Stone> array, List<Stone> stones1, List<Stone> stones2)
        {
            int sum1 = 0;
            int sum2 = 0;
            for (int i = array.Count - 1; i >= 0; --i)
            {
                sum1 = 0;
                sum2 = 0;
                stones1.Clear();
                stones2.Clear();
                for (int j = array.Count - 1; j >= i; --j)
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
