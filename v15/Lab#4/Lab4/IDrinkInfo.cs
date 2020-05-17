namespace Lab4
{
    interface IDrinkInfo <T> where T: IPersonInfo
    {
        string Name { get; set; }
        T Owner { get; set; }
    }
}
