using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter count of vectors: ");
            int inputData = Int32.Parse(Console.ReadLine());

            Vector vector = new Vector(inputData);

            FillVectorArray(vector, inputData);
            Console.Clear();

            Console.Write("Enter count of rows: ");
            int rows = Int32.Parse(Console.ReadLine());
            Console.Write("Enter count of column: ");
            int column = Int32.Parse(Console.ReadLine());

            vector.VectorArray2 = new int[rows, column];

            FillVectorArray(vector, rows, column);
            Console.Clear();

            PrintVectorArray(vector, inputData);
            Console.WriteLine("Norma for one-dimensional array: " + vector.GetNorma(vector.VectorArray, inputData));
            PrintVectorArray(vector, rows, column);
            Console.WriteLine("Norma for one-dimensional array: " + vector.GetNorma(vector.VectorArray2, rows, column));
            Console.ReadLine();
        }
        public static void FillVectorArray(Vector vector, int count)
        {
            for (int i = 0; i < count; ++i)
            {
                Console.Write($"Enter your element {i + 1}) ");
                vector.VectorArray[i] = Int32.Parse(Console.ReadLine());
            }
        }
        public static void FillVectorArray(Vector vector, int rows, int column)
        {
            for (int i = 0; i < rows; ++i)
                for (int j = 0; j < column; ++j)
                {
                    Console.Write($"Enter your element [{i + 1}, {j + 1}]) ");
                    vector.VectorArray2[i, j] = Int32.Parse(Console.ReadLine());
                }
        }
        public static void PrintVectorArray(Vector vector, int count)
        {
            Console.Write("Your elements in vector array:\n");
            for (int i = 0; i < count; ++i)
                Console.Write(vector.VectorArray[i] + " ");
            Console.WriteLine();
        }
        public static void PrintVectorArray(Vector vector, int rows, int column)
        {
            Console.Write("Your elements in vector array:\n");
            for (int i = 0; i < rows; ++i)
            {
                for (int j = 0; j < column; ++j)
                {
                    Console.Write(vector.VectorArray2[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
