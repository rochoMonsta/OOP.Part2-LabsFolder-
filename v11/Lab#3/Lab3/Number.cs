namespace Lab3
{
    class Number
    {
        public int Numb { get; set; }
        public int NextNumberIndex { get; set; }
        public Number() { }
        public Number(int Numb, int NextNumberIndex)
        {
            this.Numb = Numb;
            this.NextNumberIndex = NextNumberIndex;
        }
        public override string ToString()
        {
            return $"Number: {Numb} - Next number index: {NextNumberIndex}";
        }
    }
}
