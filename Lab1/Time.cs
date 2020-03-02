namespace Lab1
{
    class Time
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int TickTime()
        {
            return (Hour * 60) + Minute;
        }
        public override string ToString()
        {
            return $"{Hour}:{Minute}";
        }
    }
}
