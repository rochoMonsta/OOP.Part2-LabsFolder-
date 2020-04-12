using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User()
            {
                Name = "Вiкторiя",
                Surname = "Дах"
            };
            User user1 = new User()
            {
                Name = "Анастасiя",
                Surname = "Худницька"
            };
            Cup<User> cup = new Cup<User>()
            {
                Name = "Велике рожеве горня",
                Owner = user,
                Filling = null
            };
            Cup<User> cup1 = new Cup<User>()
            {
                Name = "Маленьке витончене горня",
                Owner = user1,
                Filling = null
            };
            Tea<User> tea = new Tea<User>()
            {
                Name = "Зелений чай",
                Owner = user
            };

            MakeDrink<Cup<User>, Tea<User>> makeDrink = new MakeDrink<Cup<User>, Tea<User>>();
            makeDrink.MakeTea(cup, tea);
            Console.WriteLine($"{cup.Owner} - має чашку ({cup.Name}) з ({cup.Filling.Name})");
            Console.WriteLine();
            makeDrink.MakeTea(cup1, tea);
            Console.WriteLine($"{cup1.Owner} - має чашку ({cup1.Name}) з ({cup1.Filling})");
            Console.ReadLine();
        }
        public static void Swap <T> (T element1, T element2)
        {
            T box = element1;
            element1 = element2;
            element2 = box;
        }
    }
}
