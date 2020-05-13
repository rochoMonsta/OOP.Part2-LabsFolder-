namespace Lab4
{
    class Umbrella : Item
    {
        public Umbrella() { }
        public Umbrella(Person person, string name)
        {
            Name = name;
            Owner = person;
        }
    }
}
