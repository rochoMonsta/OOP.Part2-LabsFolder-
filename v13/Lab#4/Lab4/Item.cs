namespace Lab4
{
    class Item : IInfo<Person>
    {
        public string Name { get; set; }
        public Person Owner { get; set; }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
