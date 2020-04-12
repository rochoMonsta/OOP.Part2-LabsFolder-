namespace Lab4
{
    public class Tea <T> : IInfo<T>
    {
        public string Name { get; set; }
        public T Owner { get; set; }

        public override string ToString()
        {
            return $"Tea: {Name}; Owner: {Owner};";
        }
    }
}
