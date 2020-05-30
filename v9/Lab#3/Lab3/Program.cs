using System;
using System.Collections.Generic;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();

            for (int i = 1, j = 10; i <= 10; ++i, --j)
            {
                stack1.Push(i);
                stack2.Push(j);
            }
            Console.Write("Stack of 1-10:   ");
            PrintStack(stack1);
            Console.Write("Stack of 10-1:   ");
            PrintStack(stack2);

            Console.WriteLine($"\nGet element from stack1(1-10): {stack1.Pop()}");
            Console.Write("Stack of 1-10:   ");
            PrintStack(stack1);

            Console.WriteLine($"\nGet element from stack1(10-1): {stack2.Pop()}");
            Console.Write("Stack of 10-1:   ");
            PrintStack(stack2);

            var stack = GetNewStack(stack1, stack2);
            Console.WriteLine();
            PrintStack(stack);

            Console.ReadLine();
        }
        public static void PrintStack(Stack<int> stack)
        {
            foreach (var element in stack)
                Console.Write(element + " ");
            Console.WriteLine();
        }
        public static Stack<int> GetNewStack(Stack<int> stack1, Stack<int> stack2)
        {
            Stack<int> stack3 = new Stack<int>();
            int count_of_stack1 = stack1.Count;
            int count_of_stack2 = stack2.Count;

            for (int i = 0; i < count_of_stack1; ++i)
                stack3.Push(stack1.Pop());
            for (int i = 0; i < count_of_stack2; ++i)
                stack3.Push(stack2.Pop());
            return stack3;
        }
    }
}
