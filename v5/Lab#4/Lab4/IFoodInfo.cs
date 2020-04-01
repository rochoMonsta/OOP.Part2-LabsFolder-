using System;
namespace Lab4
{
    interface IFoodInfo <T>
    {
        T FoodOwner { get; set; }
    }
}
