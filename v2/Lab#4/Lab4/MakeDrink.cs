using System;

namespace Lab4
{
    class MakeDrink <T, U> where T : Cup<User>
                           where U : Tea<User>
    {
        public void MakeTea(T element1, U element2)
        {
            if (element1.Owner == element2.Owner)
            {
                element1.Filling = element2;
                Console.WriteLine($"{element1.Owner.Name} - зробила  {element2.Name}");
            }
            else
                Console.WriteLine($"{element1.Owner.Name} - не чiпай цей чай: ({element2.Name}) - це власнiсть: ({element2.Owner.Name})!!!");
        }
    }
}
