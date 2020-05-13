namespace Lab4
{
    class Person : IPersonInfo
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int KeyForCell { get; set; }
        public Item Item { get; set; }
        public override string ToString()
        {
            return $"Supermarket user:\n\tName: ({Name} {Surname})\n\tAge: ({Age})\n\tKey for cell: ({KeyForCell})\n\tItem: ({Item})\n";
        }
    }
}
