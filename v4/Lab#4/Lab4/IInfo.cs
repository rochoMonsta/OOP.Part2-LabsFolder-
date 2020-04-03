namespace Lab4
{
    interface IInfo<T>
    {
        string Name { get; set; }
        T Owner { get; set; }
        T GetOwner();
        void SetOwner(T owner);
    }
}
