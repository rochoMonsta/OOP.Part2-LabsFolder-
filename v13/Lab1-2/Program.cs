using System;
using System.Collections.Generic;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArraySort array = new ArraySort();

            Console.Write("Enter count of numbers in array: ");
            int count = Int32.Parse(Console.ReadLine());

            List<int> array1 = new List<int>();
            List<int> array2 = new List<int>();

            InputElementToArray(array1, count);
            InputElementToArray(array2, count);

            array.InsertionSort(array1);
            array.QuickSort(array2, 0, array2.Count - 1);

            PrintArray(array1);
            PrintArray(array2);

            Console.WriteLine("\nResult: " + GetSum(array1, array2));

            Console.ReadLine();
        }
        public static int GetSum(List<int> arr1, List<int> arr2)
        {
            if (arr1.Count != arr2.Count)
                return 0;
            else
            {
                int sum = 0;
                for (int i = 0; i < arr1.Count; ++i)
                    sum += arr1[i] * arr2[arr1.Count - 1 - i];
                return sum;
            }
        }
        public static void InputElementToArray(List<int> array, int count)
        {
            Console.WriteLine("Enter elements to list:");
            for (int i = 0; i < count; ++i)
            {
                Console.Write($"\t{i + 1}) ");
                array.Add(Int32.Parse(Console.ReadLine()));
            }
        }
        public static void PrintArray(List<int> array)
        {
            Console.WriteLine();
            foreach (var element in array)
                Console.Write(element + " ");
            Console.WriteLine();
        }
    }
}
