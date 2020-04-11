using System;
using System.Collections.Generic;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sort sort = new Sort();

            Console.Write("Enter count of numbers (n): ");
            int CountOfNumbers = Int32.Parse(Console.ReadLine());
            Console.Write("Enter count of numbers for sort (k): ");
            int CountOfNumbersForSort = Int32.Parse(Console.ReadLine());

            CheckForCorrectK(ref CountOfNumbersForSort, CountOfNumbers);

            List<int> NumbersArray = new List<int>();

            FillArrayByRandomNumbers(NumbersArray, CountOfNumbers);
            Console.WriteLine("Array without sorting:\n");
            PrintArray(NumbersArray, CountOfNumbers);

            Console.WriteLine("Array after sorting:\n");
            //sort.InsertionSort(NumbersArray, CountOfNumbersForSort);
            sort.QuickSort(NumbersArray, 0, CountOfNumbersForSort);
            PrintArray(NumbersArray, CountOfNumbers);

            Console.ReadLine();
        }
        //Метод який виконує перевірку коректності введеного k
        public static void CheckForCorrectK(ref int countForSort, int NumbersCount)
        {
            double max = NumbersCount - NumbersCount * 0.25;
            double min = NumbersCount - NumbersCount * 0.75;
            while (countForSort >= max || countForSort <= min)
            {
                Console.Write($"Enter correct k ({Math.Round(min)} < k < {Math.Round(max)}): ");
                countForSort = Int32.Parse(Console.ReadLine());
            }
        }
        //Метод який виконує заповнення масива рандомно згенерованими числами
        public static void FillArrayByRandomNumbers(List<int> array, int count)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < count; ++i)
                array.Add(random.Next(0, count));
        }
        //Метод який виводить масив чисел на екран
        public static void PrintArray(List<int> array, int count)
        {
            for (int i = 0; i < count; ++i)
                Console.Write(array[i] + " ");
            Console.WriteLine("\n");
        }
    }
}
