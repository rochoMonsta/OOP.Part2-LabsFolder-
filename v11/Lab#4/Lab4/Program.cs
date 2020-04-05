using System;
using System.Collections.Generic;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            User Christina = new User()
            {
                Login = "christina_126",
                Password = "Koblevo"
            };
            Computer<User> computer = new Computer<User>()
            {
                Name = "MacBook Air 13",
                Company = "Apple",
                Model = "MacBook Air",
                Owner = Christina
            };

            User Solomiya = new User()
            {
                Login = "candy_mia12",
                Password = "loverocho"
            };
            Computer<User> computer1 = new Computer<User>()
            {
                Name = "HP211233",
                Company = "HP",
                Model = "ProBook",
                Owner = Solomiya
            };

            List<Computer<User>> computers = new List<Computer<User>>();
            computers.Add(computer);
            computers.Add(computer1);

            Console.Write("Enter login: ");
            string login = Console.ReadLine();
            Console.Write($"Enter {login} password: ");
            string password = Console.ReadLine();

            CheckLoginAndPassword<Computer<User>> CheckLoginPassword = new CheckLoginAndPassword<Computer<User>>();
            var isCorect = CheckLoginPassword.CheckPasswordForLogin(login, password, computers);
            if (isCorect)
                Console.WriteLine($"Welcome, {login}!");
            else
                Console.WriteLine("Error! Input login or password isn't correct!");
            Console.ReadLine();
        }
        public static void Swap<T>(T first, T second)
        {
            T fake = first;
            first = second;
            second = fake;
        }
    }
}