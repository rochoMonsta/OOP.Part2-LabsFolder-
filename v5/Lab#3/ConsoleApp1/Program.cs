using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vector> vectorsList = new List<Vector>();

            Console.Write("Enter count of Vectors: ");
            int inputData = Int32.Parse(Console.ReadLine());

            AddVectorToCollection(vectorsList, inputData);
            Console.Clear();
            PrintVectorList(vectorsList);

            Vector vector = Vector.AddingVectors(vectorsList);
            Console.WriteLine("Adding vectors collection:\n" + vector);
            Console.WriteLine("Product vectors collection:\n\t" + Vector.ScalarProductOfVectors(vectorsList));

            //Вилучення вектора з колекції по індексу.
            Console.Write("Enter the index of the item you want to delete: ");
            int removeIndex = Int32.Parse(Console.ReadLine());
            vectorsList.RemoveAt(removeIndex - 1);
            PrintVectorList(vectorsList);

            Console.ReadLine();
        }
        //Метод, в якому ініціалізуються нові об'єкти класа Vector.
        public static Vector CreateNewVector()
        {
            Console.WriteLine("Input Vector (x, y)");
            Console.Write("\tX: ");
            int X = Int32.Parse(Console.ReadLine());
            Console.Write("\tY: ");
            int Y = Int32.Parse(Console.ReadLine());

            return new Vector(X, Y);
        }
        //Цикл в якому створюються нові вектори після чого, вони добавляються в колекцію.
        public static void AddVectorToCollection(List<Vector> collection, int lenth)
        {
            for (int i = 0; i < lenth; ++i)
                collection.Add(CreateNewVector());
        }
        //Виведення колекції векторів.
        public static void PrintVectorList(List<Vector> vectorList)
        {
            Console.WriteLine("Your vectors:");
            for (int i = 0; i < vectorList.Count; ++i)
                Console.WriteLine($"{i + 1}){vectorList[i]}");
        }
    }
}
