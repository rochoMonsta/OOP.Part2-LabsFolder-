using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                Name = "Чолкан",
                Surname = "Роман",
                Age = 20
            };
            Person person1 = new Person()
            {
                Name = "Соломія",
                Surname = "Сорокотяга",
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
