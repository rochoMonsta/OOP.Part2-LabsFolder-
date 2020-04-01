using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintByUsing<Printer<Person>> printByUsing = new PrintByUsing<Printer<Person>>();

            var person1 = new Person("Вiкторiя", "Дах");
            var person2 = new Person("Анастасiя", "Худницька");

            Console.WriteLine("Enter your text:");
            string text = Console.ReadLine();

            Printer<Person> printer1 = new Printer<Person>()
            {
                Name = "DD2102",
                Firm = "HP",
                Type = "Laser print",
                Price = 100,
                SendingBy = person1,
                SendingTo = person2,
                DocumentFilling = text
            };
            Printer<Person> printer2 = new Printer<Person>()
            {
                Name = "KD2213",
                Firm = "Epson",
                Type = "Laser print",
                Price = 350,
                SendingBy = person1,
                SendingTo = person2,
                DocumentFilling = text
            };
            Console.Clear();
            printByUsing.PrintDocument(printer1);
            Swap<Printer<Person>>(ref printer1, ref printer2);
            Console.WriteLine("\n");
            printByUsing.PrintDocument(printer1);

            Console.ReadLine();
        }
        public static void Swap <T> (ref T p1, ref T p2)
        {
            T fake = p1;
            p1 = p2;
            p2 = fake;
        }
    }
}
