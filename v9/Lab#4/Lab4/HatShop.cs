using System;
using System.Collections.Generic;

namespace Lab4
{
    class HatShop<H> where H: IItemInfo
    {
        public string Name { get; set; }
        private int ShopBalance = 0;
        public List<Item> items = new List<Item>();
        private bool CheckForBalance(Shopper shopper, H item)
        {
            if (items.Contains(item as Item))
            {
                if (shopper.Balance >= item.Price)
                {
                    shopper.Balance -= item.Price;
                    ShopBalance += item.Price;

                    shopper.AddItem(item as Item);
                    items.Remove(item as Item);
                    return true;
                }
                else
                {
                    Console.WriteLine($"\n{shopper.Name}, you don't have enough money for \"{item.Name}\"\n");
                    return false;
                }
            }
            else
            {
                Console.WriteLine($"\n{item.Name}, is not owned by the store.\n");
                return false;
            }
        }
        public void BuyItem(Shopper shopper, H item)
        {
            if (CheckForBalance(shopper, item))
                Console.WriteLine($"\nThank you, {shopper.Name} for buying a hat \"{item.Name}\". Se you next time.\n");
            else
                Console.WriteLine($"\nSorry {shopper.Name}, we can't sold you this hat \"{item.Name}\".\n");
        }
        public void GetItemsInShop()
        {
            Console.WriteLine();
            foreach (var element in items)
                Console.WriteLine(element);
            Console.WriteLine();
        }
        public void GetCountOfItemsInShop()
        {
            Console.WriteLine("\nCount of items in shop: " + items.Count + "\n");
        }
    }
}
