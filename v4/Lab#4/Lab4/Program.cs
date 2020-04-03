using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { Name = "Дмитро", Surname = "Гук" };

            Clock<Person> clock = new Clock<Person>();
            clock.SetCurrentTime();
            clock.SetOwner(person);
            clock.Name = "Rolex";

            Console.Write("Enter time in format (hour:minute:second): ");
            string time = Console.ReadLine();

            ClockFunctionality<Clock<Person>> clockFunctionality = new ClockFunctionality<Clock<Person>>();
            clockFunctionality.Timer(clock, time);

            Console.ReadLine();
        }
        public static void Change <T> (ref T first, ref T second)
        {
            T box = first;
            first = second;
            second = box;
        }
    }
}
