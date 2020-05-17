namespace Lab4
{
    class Person : IPersonInfo
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"Supermarket user:\n\tName: ({Name} {Surname})\n\tAge: ({Age})\n";
        }
    }
}
