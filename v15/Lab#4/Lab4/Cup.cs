namespace Lab4
{
    class Cup <T> where T : Drink
    {
        public T DrinkIn { get; set; }
        public Person Owner { get; set; }
        public string Name { get; set; }
        public void PutSomeDrinkIn(T Drink, Person person)
        {
            if (Owner == person)
            {
                System.Console.WriteLine($"{person.Name} - налила \"{Drink.Name}\" в \"{Name}\".");
                DrinkIn = Drink;
            }
            else
                System.Console.WriteLine($"{person.Name} - це не твоя чашка, вибери iншу!");
        }
    }
}
