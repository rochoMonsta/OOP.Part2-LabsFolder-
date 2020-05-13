using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Cell<Item>[] SupermarketCells = new Cell<Item>[2]
            {
                new Cell<Item>() {Id = 1, Key = 2323},
                new Cell<Item>() {Id = 2, Key = 1344}
            };

            Person SupermarketUser1 = new Person()
            {
                Name = "Роман",
                Surname = "Сагайдак",
                Age = 20
            };
            Person SupermarketUser2 = new Person()
            {
                Name = "Грабiжник",
                Surname = "Петро",
                Age = 69
            };

            Umbrella umbrella = new Umbrella(SupermarketUser1, "Улюблена парасолька");
            SupermarketUser1.Item = umbrella;

            Console.WriteLine(SupermarketUser1);
            Console.WriteLine(SupermarketCells[0]);
            Console.WriteLine("-------------------------------------------------------------");

            CheckForEmptyCell(SupermarketUser1, SupermarketCells[0]);

            Console.WriteLine(SupermarketUser1);
            Console.WriteLine(SupermarketCells[0]);
            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine($"{SupermarketUser1.Name} {SupermarketUser1.Surname} купив деякi продукти.");
            Console.WriteLine($"{SupermarketUser1.Name} {SupermarketUser1.Surname} хоче забрати свої речi з ячейки.");

            CheckForCorrectKey(SupermarketUser2, SupermarketCells[0]);
            CheckForCorrectKey(SupermarketUser1, SupermarketCells[0]);

            Console.ReadLine();
        }
        public static void Swap(Person person, Cell<Item> cell)
        {
            Item item = person.Item;
            person.Item = cell.ItemIn;
            cell.ItemIn = item;
            person.KeyForCell = cell.Key;
        }
        public static void CheckForEmptyCell(Person person, Cell<Item> cell)
        {
            if (cell.ItemIn == null)
            {
                Console.WriteLine($"\n{person.Name} {person.Surname} - поклав свою \"{person.Item}\" в ячейку з Id {cell.Id}.\n");
                Swap(person, cell);
            }
            else
                Console.WriteLine("\nЯчейка зайнята, виберiть собі якусь iншу!");
        }
        public static void CheckForCorrectKey(Person person, Cell<Item> cell)
        {
            if (person.KeyForCell == cell.Key)
            {
                Console.WriteLine($"\n{person.Name} {person.Surname} - забрав \"{cell.ItemIn}\" з ячейки пiд Id {cell.Id}.\n");
                Swap(person, cell);
            }
            else
                Console.WriteLine($"\n{person.Name} {person.Surname} - ваш ключ не пiдходить для ячейки з iндексом {cell.Id}!\n");
        }
    }
}
