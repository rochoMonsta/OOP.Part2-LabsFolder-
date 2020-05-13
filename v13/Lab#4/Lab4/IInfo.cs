namespace Lab4
{
    interface IInfo <T> where T :IPersonInfo
    {
        string Name { get; set; }
        T Owner { get; set; }
    }
}
