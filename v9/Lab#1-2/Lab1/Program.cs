using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorting sorting = new Sorting();

            Console.Write("Enter count of numbers: ");
            int input_count = Int32.Parse(Console.ReadLine());

            List<int> list = new List<int>();
            NumberRandomGenerator(list, input_count);

            Console.WriteLine("Array without sorting\n-------------------------------------------");
            Print(list);
            Console.WriteLine("Array after sorting\n---------------------------------------------");
            sorting.MergeSort(list, 0, list.Count - 1);
            Print(list);

            Console.WriteLine($"Count of unique numbers = {GetCountOfUniqueNumbers(list)}");

            Console.ReadLine();
        }
        public static void NumberRandomGenerator(List<int> array, int count)
        {
            Random random = new Random(Guid.NewGuid().ToByteArray().Sum(x => x));
            for (int i = 0; i < count; ++i)
                array.Add(random.Next(0, 1000));
        }
        public static int GetCountOfUniqueNumbers(List<int> array)
        {
            List<int> new_array = array.Distinct().ToList();
            return new_array.Count;
        }
        public static void Print(List<int> array)
        {
            Console.WriteLine();
            foreach (var element in array)
                Console.Write(element + " ");
            Console.WriteLine("\n");
        }
    }
}
