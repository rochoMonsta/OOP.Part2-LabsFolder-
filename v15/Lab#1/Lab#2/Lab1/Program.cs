using System;
using System.Collections.Generic;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            List<int> segmentArray = new List<int>();
            RandomGenerator(segmentArray, 5000);

            Sorting sorting = new Sorting();
            sorting.QuickSort(segmentArray, 0, segmentArray.Count - 1);

            Console.WriteLine("Count = " + CalculateCountOfPossibleTriangles(segmentArray));
            Console.ReadLine();
        }
        //Виведення елементів масиву цілих чисел
        public static void PrintArray(int[] array)
        {
            Console.WriteLine();
            foreach (var element in array)
                Console.Write(element + " ");
            Console.WriteLine();
        }
        //Метод для перевірки на існування трикутника (перевіряються суми довжин відрізків та умова для інсування трикутника)
        //a + b> c, a + c> b, b + c> a, (a> 0, b> 0, c> 0)
        public static int CalculateCountOfPossibleTriangles(List<int> arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Count - 2; ++i)
                if (((arr[i] + arr[i + 1]) > arr[i + 2]) && ((arr[i + 1] + arr[i + 2]) > arr[i]) && ((arr[i] + arr[i + 2]) > arr[i + 1]))
                    count++;
            return count;
        }
        //Метод для генерації цілих чисел без повторів
        public static void RandomGenerator(List<int> array, int count)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < count; ++i)
            {
                int number = random.Next(1, 1000000);
                while (array.Contains(number))
                    number = random.Next(1, 1000000);
                array.Add(number);
            }
        }
    }
}
