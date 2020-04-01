using System;

namespace Lab4
{
    interface IFoodDate
    {
        DateTime DateTimeWhenPut { get; set; }
        DateTime DateTimeWhenGet { get; set; }
    }
}
