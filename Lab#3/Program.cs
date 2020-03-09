using System;
using System.Collections;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue students_list = new Queue();

            int.TryParse(Console.ReadLine(), out int count);
            for (int i = 0; i < count; ++i)
                students_list.Enqueue(new Student().StudentRandomGenerator());
            Console.WriteLine("Students in: " + students_list.GetType() + "\n");
            foreach (var element in students_list)
                Console.WriteLine(element/*or student_list.Peek();*/);
            Console.WriteLine("\n\nStudents stay at the queue:\n");
            for (int i = 0; i < count; ++i)
            {
                Console.WriteLine($"Students in queue: {students_list.Count}");
                Console.WriteLine("\t" + students_list.Peek() + " buy products.");
                students_list.Dequeue();
            }
            Console.WriteLine($"\nStudents in queue: {students_list.Count}");
            Console.Write("Enter new student: ");
            string[] newStudent = Console.ReadLine().Split();
            students_list.Enqueue(new Student(newStudent));
            Console.WriteLine($"\nStudents in queue: {students_list.Count}");
            foreach (var element in students_list)
                Console.WriteLine(element/*or student_list.Peek();*/);
            Console.ReadLine();
        }
    }
}
