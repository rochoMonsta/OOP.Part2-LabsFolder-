using System;
using System.Collections.Generic;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sort sort = new Sort();

            Console.Write("Enter count of numbers in arrays: ");
            int inputData = Int32.Parse(Console.ReadLine());

            List<int> Array1 = new List<int>();
            List<int> Array2 = new List<int>();

            InputDataToArray(Array1, inputData);
            InputDataToArray(Array2, inputData);

            //Сортування за допомогою алгоритма Шелла
            sort.ShellaSort(Array1);
            sort.ShellaSort(Array2);

            //Сортування за допомогою простого або бульбашкового методу
            //sort.BubleSort(Array1);
            //sort.BubleSort(Array2);

            PrintArray(Array1);
            PrintArray(Array2);

            CheckArrays(Array1, Array2);
            Console.ReadLine();
        }
        public static void InputDataToArray(List<int> array, int lenth)
        {
            for (int i = 0; i < lenth; ++i)
            {
                Console.Write($"Enter number for {i + 1}: ");
                int input = Int32.Parse(Console.ReadLine());
                while (array.Contains(input))
                {
                    Console.Write("\nEnter other number: ");
                    input = Int32.Parse(Console.ReadLine());
                }
                array.Add(input);
            }
            Console.Clear();
        }
        public static void PrintArray(List<int> array)
        {
            Console.Write("Your array:\n\t");
            foreach (var element in array)
                Console.Write(element + " ");
            Console.WriteLine("\n");
        }
        public static void CheckArrays(List<int> array1, List<int> array2)
        {
            if (array1.Count == array2.Count)
            {
                Console.Write("Same numbers in both array:\n\t");
                for (int i = 0; i < array1.Count; ++i)
                {
                    if (array1[i] == array2[i])
                        Console.Write(array1[i] + " ");
                }
            }
            else
                Console.WriteLine("Your list have different lenth.");
        }
    }
}
