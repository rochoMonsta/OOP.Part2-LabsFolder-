using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sort = new Sort();
            Console.Write("Enter count of numbers: ");
            int countOfData = Int32.Parse(Console.ReadLine());

            int[] array1 = new int[countOfData];
            int[] array2 = new int[countOfData];

            InputDataToList(array1, countOfData);
            InputDataToList(array2, countOfData);

            Console.WriteLine("Numbers array without sorting:");
            PrintArray(array1);
            PrintArray(array2);

            //сортування злиттям
            //sort.MergeSort(array1, 0, countOfData - 1);
            //sort.MergeSort(array2, 0, countOfData - 1);
            //Console.WriteLine("Numbers array when sorting by MergeSort:");
            //сортування змішуванням
            sort.ShakerSort(array1);
            sort.ShakerSort(array2);
            Console.WriteLine("Numbers array when sorting by ShakerSort:");

            PrintArray(array1);
            PrintArray(array2);

            Console.WriteLine(GetResult(array1, array2, countOfData) == false? "This array isn't same." : "Same arrays.");

            Console.ReadLine();
        }
        public static void PrintArray <T> (T[] array)
        {
            Console.Write("\n\t");
            foreach (var element in array)
                Console.Write(element + " ");
            Console.WriteLine();
        }
        public static void InputDataToList(int[] array, int count)
        {
            Console.WriteLine("Enter numbers to list:");
            for (int i = 0; i < count; ++i)
            {
                Console.Write($"{i + 1}) ");
                array[i] = Int32.Parse(Console.ReadLine());
            }
        }
        public static bool GetResult(int[] array1, int[] array2, int count)
        {
            for (int i = 0; i < count; ++i)
            {
                bool result = array1[i] == array2[i] ? true : false;
                if (!result)
                    return false;
            }
            return true;
        }
    }
}
