namespace Lab4
{
    class Cell <T> where T: IInfo<Person>
    {
        public int Id { get; set; }
        public int Key { get; set; }
        public T ItemIn { get; set; }
        public override string ToString()
        {
            return $"Supermarket cell:\n\tItem ({ItemIn}) in cell ID ({Id}) with key ({Key})\n";
        }
    }
}
