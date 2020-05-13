using System;
using System.Collections.Generic;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter count of numbers: ");
            int count = Int32.Parse(Console.ReadLine());

            List<Number> numbers = new List<Number>();

            InputDataToList(numbers, count);
            PrintList(numbers);
            Console.WriteLine("----------------------------------------------");

            Console.Write("Введiть число яке хочете занести на початок лiнiйного списку: ");
            count = Int32.Parse(Console.ReadLine());
            AddElementInStartOfList(numbers, count);
            PrintList(numbers);
            Console.WriteLine("----------------------------------------------");

            Console.Write("Введiть число яке хочете занести в кiнець лiнiйного списку: ");
            count = Int32.Parse(Console.ReadLine());
            AddElementInTheEnd(numbers, count);
            PrintList(numbers);
            Console.WriteLine("----------------------------------------------");

            Console.Write("Введiть число яке хочете вставити по iндексу: ");
            count = Int32.Parse(Console.ReadLine());
            Console.Write("Введiть iндекс куди потрiбно вставити число: ");
            int index = Int32.Parse(Console.ReadLine());
            AddElementByIndex(numbers, index, count);
            PrintList(numbers);
            Console.WriteLine("----------------------------------------------");

            Console.Write("Введiть iндекс числа яке хочете вилучити зi списку: ");
            index = Int32.Parse(Console.ReadLine());
            RemoveItemByIndex(numbers, index);
            PrintList(numbers);
            Console.WriteLine("----------------------------------------------");

            Console.ReadLine();
        }
        public static void InputDataToList(List<Number> list, int count)
        {
            Console.WriteLine("Enter your numbers:");
            for (int i = 0; i < count; ++i)
            {
                Console.Write($"\t{i + 1}) ");
                bool result = Int32.TryParse(Console.ReadLine(), out int input);
                if (result)
                {
                    Number number;
                    if (i != count - 1)
                    {
                        number = new Number(input, i + 1);
                    }
                    else
                    {
                        number = new Number(input, 0);
                    }
                    list.Add(number);
                }
                else
                    Console.WriteLine("Uncorrect type of number.");
            }
        }
        public static void PrintList(List<Number> list)
        {
            Console.WriteLine("Your list:");
            for (int i = 0; i < list.Count; ++i)
                Console.WriteLine($"\tIndex {i}) " + list[i]);
            Console.WriteLine();
        }
        //Видаляємо елемент з однозв'язного лінійного списку по індексу
        public static void RemoveItemByIndex(List<Number> list, int index)
        {
            if (index < list.Count && index >= 0)
            {
                if (index != list.Count - 1)
                    for (int i = index + 1; i < list.Count - 1; ++i)
                        list[i].id -= 1;
                else
                    list[index - 1].id = 0;
                list.RemoveAt(index);
            }
            else
                Console.WriteLine("Index out of range.");
        }
        //Вставляємо елемент в однозв'язний лінійний список по індексу
        public static void AddElementByIndex(List<Number> list, int index, int number)
        {
            if (index < list.Count && index >= 0)
            {
                if (index != list.Count - 1)
                {
                    for (int i = index; i < list.Count - 1; ++i)
                        list[i].id += 1;
                    list.Insert(index, new Number(number, index + 1));
                }
                else
                {
                    list[index - 1].id = index;
                    list.Insert(index, new Number(number, index + 1));
                }    
            }
            else
                Console.WriteLine("Index out of range.");
        }
        //Додаємо елемент в кінець однозв'язного лінійного списку
        public static void AddElementInTheEnd(List<Number> list, int number)
        {
            list[list.Count - 1].id = list.Count;
            list.Add(new Number(number, 0));
        }
        //Додаємо елемент на початок однозв'язного лінійного списку
        public static void AddElementInStartOfList(List<Number> list, int number)
        {
            for (int i = 0; i < list.Count - 1; ++i)
                list[i].id += 1;
            list.Insert(0, new Number(number, 1));
        }
    }
}
