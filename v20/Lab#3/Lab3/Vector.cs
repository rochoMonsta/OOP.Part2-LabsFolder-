using System;

namespace Lab3
{
    class Vector
    {
        public int[] VectorArray;
        public int[,] VectorArray2;
        public double GetNorma(int[] array, int count)
        {
            int TheSumOfSquares = 0;
            for (int i = 0; i < count; ++i)
                TheSumOfSquares += array[i] * array[i];
            return Math.Round(Math.Sqrt(TheSumOfSquares), 2);
        }
        public int GetNorma(int[,] array, int rows, int column)
        {
            int MaximumValueForTheModule = 0;
            for (int i = 0; i < rows; ++i)
            {
                for (int j = 0; j < column; ++j)
                {
                    if (MaximumValueForTheModule < Math.Abs(array[i, j]))
                        MaximumValueForTheModule = Math.Abs(array[i, j]);
                }
            }
            return MaximumValueForTheModule;
        }
        public Vector() { }
        public Vector(int size)
        {
            VectorArray = new int[size];
        }
        public Vector(int rows, int column)
        {
            VectorArray2 = new int[rows, column];
        }
    }
}
