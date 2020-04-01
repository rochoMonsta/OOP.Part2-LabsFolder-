using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();
            dateTime = DateTime.Now;
            Console.WriteLine(dateTime);
            Person person = new Person()
            {
                Name = "Ira",
                Surname = "Durkavets"
            };
            Food<Person> Apple = new Food<Person>()
            {
                Name = "Apple",
                Volume = 30,
                FoodOwner = person
            };
            Food<Person> Meat = new Food<Person>()
            {
                Name = "Meat",
                Volume = 220,
                FoodOwner = person
            };

            Refrigerator<Food<Person>> refrigerator = new Refrigerator<Food<Person>>();
            refrigerator.PutInRefrigerator(Apple, Meat);
            Console.WriteLine("Refrigerator contents:");
            refrigerator.PrintRefrigeratorContents();
            Console.ReadLine();

            Console.WriteLine("\nGet from refrigerator food by index 1:");
            var food = refrigerator.GetFromRefrigerator(1);
            Console.WriteLine(food);
            Console.ReadLine();
        }
    }
}
