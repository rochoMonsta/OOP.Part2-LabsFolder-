namespace Lab4
{
    class Juice : Drink
    {
        public Juice() { }
        public Juice(string Name, Person Owner)
        {
            this.Name = Name;
            this.Owner = Owner;
        }
        public bool CheckForCorrectOwner(Person person)
        {
            if (Owner == person)
            {
                System.Console.WriteLine($"{person.Name} - взяла сiк \"{Name}\".");
                return true;
            } 
            else
            {
                System.Console.WriteLine($"{person.Name} - \"{Name}\" це не твiй сiк! Вiзьми свiй!");
                return false;
            }
        }
    }
}
