namespace Lab4
{
    class Computer<T> : IComputerOwnerInfo<T>, IComputerInfo
    {
        public T Owner { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Model { get; set; }
        public override string ToString()
        {
            return $"Computer: {Name}:\n\tCompany: {Company};\n\tModel: {Model};\n\tOwner: {Owner};\n";
        }
    }
}
