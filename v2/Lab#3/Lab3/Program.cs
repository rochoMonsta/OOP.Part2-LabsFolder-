using System;
using System.Collections.Generic;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> NumbersSteck = new Stack<int>();

            Console.Write("Enter count of numbers: ");
            int count = Int32.Parse(Console.ReadLine());

            InputNumberToStack(NumbersSteck, count);
            PrintStack(NumbersSteck);
            //Додавання елемента поверх стеку
            Console.Write("Enter number for adding to stack: ");
            int number = Int32.Parse(Console.ReadLine());
            NumbersSteck.Push(number);
            PrintStack(NumbersSteck);

            Console.WriteLine("Remove element from stack (twice):");
            //Забираємо елемент зі стеку
            NumbersSteck.Pop();
            NumbersSteck.Pop();
            PrintStack(NumbersSteck);

            //Отримуємо перший елемент зі стеку без його видалення
            Console.Write("Get top element from stack but don't delete it: ");
            int element = NumbersSteck.Peek();
            Console.WriteLine(element);
            PrintStack(NumbersSteck);

            Console.WriteLine($"Max element from stack: {GetMaxElementFromStack(NumbersSteck)}");
            Console.WriteLine($"Min element from stack: {GetMinElementFromStack(NumbersSteck)}");

            Console.ReadLine();
        }
        public static void InputNumberToStack(Stack<int> stack, int count)
        {
            for (int i = 0; i < count; ++i)
            {
                Console.Write($"Enter number {i + 1}) ");
                int number = Int32.Parse(Console.ReadLine());
                //Операція розміщення елемента на початок черги
                stack.Push(number);
            }
        }
        //Метод виведення всіх елементів стеку в порядку виходу з нього
        public static void PrintStack(Stack<int> stack)
        {
            Console.Write("Your stack:\n\t");
            foreach (var element in stack)
                Console.Write(element + " ");
            Console.WriteLine("\n");
        }
        //Метод для пошуку максимального елемента стеку
        public static int GetMaxElementFromStack(Stack<int> stack)
        {
            int max = 0;
            foreach (var element in stack)
                if (max < element)
                    max = element;
            return max;
        }
        //Метод для пошуку мінімального елемента стеку
        public static int GetMinElementFromStack(Stack<int> stack)
        {
            int min = stack.Peek();
            foreach (var element in stack)
                if (min > element)
                    min = element;
            return min;
        }
    }
}
