using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                Name = "Софiя",
                Surname = "Cулима",
                Age = 20
            };
            Person person1 = new Person()
            {
                Name = "Ольга",
                Surname = "Корiнь",
                Age = 20
            };
            Juice juice = new Juice()
            {
                Name = "Наш сiк",
                Owner = person
            };
            Cup<Drink> cup = new Cup<Drink>()
            {
                Name = "Улюблене рожеве горнятко",
                Owner = person
            };
            if (juice.CheckForCorrectOwner(person))
                cup.PutSomeDrinkIn(juice, person);

            if (juice.CheckForCorrectOwner(person1))
                cup.PutSomeDrinkIn(juice, person1);
            Console.ReadLine();
        }
    }
}
