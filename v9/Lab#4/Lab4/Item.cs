namespace Lab4
{
    class Item : IItemInfo
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Brand { get; set; }
        public Item() { }
        public Item(string Name, int Price)
        {
            this.Name = Name;
            this.Price = Price;
        }
        public override string ToString()
        {
            return $"Item info:\n\tItem name: {Name};\n\tItem price: {Price};\n\tBrand: {Brand};\n";
        }
    }
}
