using System;

namespace Lab4
{
    class Food<T> : IFoodDate, IFoodInfo<T>
    {
        public string Name { get; set; }
        public int Volume { get; set; }
        public T FoodOwner { get; set; }
        public DateTime DateTimeWhenPut { get; set; }
        public DateTime DateTimeWhenGet { get; set; }
        public Food() { }
        public Food(string Name, int Volume)
        {
            this.Name = Name;
            this.Volume = Volume;
        }
        public override string ToString()
        {
            return $"Food:\n\tName: {Name};\n\tVolume: {Volume};\n\tFood owner: {FoodOwner};" +
                $"\n\tDate when put: {DateTimeWhenPut};\n\tDate when get: {DateTimeWhenGet};\n";
        }
    }
}
