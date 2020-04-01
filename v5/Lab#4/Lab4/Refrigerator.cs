using System;
using System.Collections.Generic;

namespace Lab4
{
    class Refrigerator <T> where T: IFoodInfo<Person>, IFoodDate
    {
        private List<T> RefrigeratorFreezer = new List<T>();

        public void PutInRefrigerator(T element)
        {
            element.DateTimeWhenPut = DateTime.Now;
            RefrigeratorFreezer.Add(element);
        }
        public void PutInRefrigerator(params T[] elements)
        {
            foreach (T element in elements)
            {
                element.DateTimeWhenPut = DateTime.Now;
                RefrigeratorFreezer.Add(element);
            }
        }
        public T GetFromRefrigerator(int index)
        {
            var element = RefrigeratorFreezer[index];
            RefrigeratorFreezer.RemoveAt(index);
            element.DateTimeWhenGet = DateTime.Now;
            return element;
        }
        public void PrintRefrigeratorContents()
        {
            foreach (var element in RefrigeratorFreezer)
                Console.WriteLine(element);
        }
    }
}
