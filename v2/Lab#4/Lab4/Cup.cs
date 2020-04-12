namespace Lab4
{
    public class Cup <T>
    {
        public string Name { get; set; }
        public T Owner { get; set; }
        public Tea<T> Filling { get; set; }
        public override string ToString()
        {
            return $"Cup name: {Name}; Cup owner: {Owner}";
        }
    }
}
