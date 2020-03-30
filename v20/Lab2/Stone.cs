using System;

namespace Lab1
{
    class Stone
    {
        public string StoneName { get; set; }
        public int StoneWeight { get; set; }
        public Stone() { }
        public Stone(string StoneName, int StoneWeight)
        {
            if (string.IsNullOrWhiteSpace(StoneName))
                throw new ArgumentNullException(nameof(StoneName), "Wrong type of name.");
            else
                this.StoneName = StoneName;
            if (StoneWeight <= 0)
                throw new ArgumentException(nameof(StoneWeight), "Wrong stone weight.");
            else
                this.StoneWeight = StoneWeight;
        }
        public override string ToString()
        {
            return $"Stone name: {StoneName}; Stone weight: {StoneWeight}";
        }
    }
}
