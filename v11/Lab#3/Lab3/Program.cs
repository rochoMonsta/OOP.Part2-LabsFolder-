using System;
using System.Collections.Generic;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter count of numbers: ");
            int inputData = Int32.Parse(Console.ReadLine());

            List<Number> numbers = new List<Number>();
            InputNumbersToList(numbers, inputData);
            PrintList(numbers);

            var numb = new Number() { Numb = 99, NextNumberIndex = 22 };
            AddNumberToList(numbers, numb);
            PrintList(numbers);

            Console.Write("Enter element index for remove: ");
            int index = Int32.Parse(Console.ReadLine());
            RemoveNumberFromListByIndex(numbers, index);
            PrintList(numbers);

            ReverseList(numbers);
            PrintList(numbers);

            Console.ReadLine();
        }
        public static void InputNumbersToList(List<Number> numbers, int count)
        {
            for (int i = 0; i < count; ++i)
            {
                int index = i + 1;
                Console.Write($"Enter number for {i + 1}) ");
                int input = Int32.Parse(Console.ReadLine());

                if (index == count)
                    index = 0;
                Number number = new Number() { Numb = input, NextNumberIndex = index };
                numbers.Add(number);
            }
        }
        public static void AddNumberToList(List<Number> numbers, Number number)
        {
            numbers[numbers.Count - 1].NextNumberIndex = numbers[numbers.Count - 2].NextNumberIndex + 1;
            number.NextNumberIndex = 0;
            numbers.Add(number);
        }
        public static void PrintList(List<Number> numbers)
        {
            Console.WriteLine("Number in yout List:");
            foreach (var element in numbers)
                Console.WriteLine($"{numbers.IndexOf(element)}) " + element);
            Console.WriteLine();
        }
        public static void RemoveNumberFromListByIndex(List<Number> numbers, int index)
        {
            if (index == numbers.Count - 1)
                numbers[numbers.Count - 2].NextNumberIndex = 0;
            else
                for (int i = index + 1; i < numbers.Count - 1; ++i)
                    numbers[i].NextNumberIndex -= 1;
            numbers.RemoveAt(index);
        }
        public static void ReverseList(List<Number> numbers)
        {
            numbers.Reverse();
            for (int i = 0; i < numbers.Count; ++i)
            {
                int index = i + 1;
                if (index == numbers.Count)
                    index = 0;
                numbers[i].NextNumberIndex = index;
            }
        }
    }
}
