using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter count of arc: ");
            int inputData = Int32.Parse(Console.ReadLine());

            Arc[] inputArcs = new Arc[inputData];

            InputArc(inputArcs, inputData);
            Console.Clear();
            Console.WriteLine("Array without sort:");
            PrintArray(inputArcs, inputData);

            Sort sort = new Sort();
            //sort.MergeSort(inputArcs, 0, inputData - 1);
            sort.DoSelectionSort(inputArcs);
            Console.WriteLine("Array after sort:");
            PrintArray(inputArcs, inputData);

            Arc arc = new Arc();
            Console.WriteLine("Painted part: " + arc.GetDrawPart(inputArcs, inputData));

            Console.ReadLine();
        }
        public static void InputArc(Arc[] arcs, int count)
        {
            for (int i = 0; i < count; ++i)
            {
                Console.WriteLine($"Enter x degree and y degree for {i + 1}:");
                Console.Write($"\t{i + 1} X) ");
                int x_degree = Int32.Parse(Console.ReadLine());

                Console.Write($"\t{i + 1} Y) ");
                int y_degree = Int32.Parse(Console.ReadLine());

                arcs[i] = new Arc(x_degree, y_degree);
            }
        }
        public static void PrintArray(Arc[] arcs, int count)
        {
            for (int i = 0; i < count; ++i)
                Console.WriteLine($"\t{i + 1}) " + arcs[i]);
            Console.WriteLine();
        }
    }
}
