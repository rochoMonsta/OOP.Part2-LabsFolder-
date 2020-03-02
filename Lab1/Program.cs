using System;
using System.Collections.Generic;

namespace Lab1
{
    class Program
    {
        public static Random random = new Random(DateTime.Now.Millisecond);
        public static List<Student> students_list = new List<Student>();
        static void Main(string[] args)
        {
            var sortedBy = new Sort();

            Console.Write("Enter count of Students: ");
            int.TryParse(Console.ReadLine(), out int students_count);
            Console.Clear();

            Console.Write("Enter a time to travel the distance from the hostel[1] to the university: ");
            string[] Hostel1_time = Console.ReadLine().Split(',');

            Console.Write("Enter a time to travel the distance from the hostel[2] to the university: ");
            string[] Hostel2_time = Console.ReadLine().Split(',');

            InputCycle(students_count);
            PrintList(students_list);
            Console.WriteLine();

            foreach (var element in students_list)
                element.TimeOfWalking(Hostel1_time, Hostel2_time);

            PrintList(students_list);

            //Console.WriteLine("\nSORTED BY BUBBLE SORT\n");
            //sortedBy.BubleSort(students_list);
            Console.WriteLine("\nSorted by shella\n");
            sortedBy.ShellaSort(students_list);
            PrintList(students_list);

            Console.ReadLine();
        }
        public static void InputCycle(int count)
        {
            for (int i = 0; i < count; ++i)
            {
                var student = new Student();
                student.RandomGenerator();
                students_list.Add(student);
            }
        }
        public static void PrintList <T> (List<T> list)
        {
            foreach (T element in list)
                Console.WriteLine(element);
        }
    }
}
