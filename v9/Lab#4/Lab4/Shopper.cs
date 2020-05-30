using System.Collections.Generic;

namespace Lab4
{
    class Shopper : IPerson
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Balance { get; set; }
        private List<Item> items = new List<Item>();
        public Shopper() { }
        public Shopper(string Name, string Surname, int Age, string Gender, int Money)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
            this.Gender = Gender;
            this.Balance = Money;
        }
        public void AddItem(Item item)
        {
            items.Add(item);
        }
        public Item GetItem(int index)
        {
            if (index < items.Count && index >= 0)
                return items[index];
            else
                return null;
        }
        public override string ToString()
        {
            return $"Shopper info:\n\tName: {Name};\n\tSurname: {Surname};\n\tAge: {Age};\n\tGender: {Gender};\n\tBalance: {Balance};\n";
        }
    }
}
