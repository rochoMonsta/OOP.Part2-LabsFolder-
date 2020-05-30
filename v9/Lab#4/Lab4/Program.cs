using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Shopper shopper = new Shopper()
            {
                Name = "Pavlo",
                Surname = "Mikhailenko",
                Age = 20,
                Gender = "Male",
                Balance = 1000
            };
            Console.WriteLine(shopper);

            Item item1 = new Item() { Name = "Green Hat", Price = 185, Brand = "H&M" };
            Item item2 = new Item() { Name = "Big blue cap", Price = 1200, Brand = "Gucci" };
            Item item3 = new Item() { Name = "Orange cap", Price = 700, Brand = "Pull&Bear" };
            Item item4 = new Item() { Name = "Playstation 4", Price = 400, Brand = "Sony" };

            HatShop<Item> hatShop = new HatShop<Item>() { Name = "Ashot shop" };
            hatShop.items.Add(item1);
            hatShop.items.Add(item2);
            hatShop.items.Add(item3);

            hatShop.GetCountOfItemsInShop();

            hatShop.BuyItem(shopper, item1);
            Console.WriteLine(shopper);
            hatShop.GetCountOfItemsInShop();

            hatShop.BuyItem(shopper, item4);
            hatShop.BuyItem(shopper, item2);

            Console.ReadLine();
        }
    }
}
