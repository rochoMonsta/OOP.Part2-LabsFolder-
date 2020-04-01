namespace Lab4
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Person() { }
        public Person(string Name, string Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
        }
        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
