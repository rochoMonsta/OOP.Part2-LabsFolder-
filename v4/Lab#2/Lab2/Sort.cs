using System.Collections.Generic;

namespace Lab1
{
    public class Sort
    {
        public void BubleSort(List<int> array)
        {
            for (int i = 0; i < array.Count; ++i)
            {
                for (int j = 0; j < array.Count - 1; ++j)
                {
                    if (array[j] > array[j + 1])
                    {
                        int fake = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = fake;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
        public void ShellaSort(List<int> array)
        {
            var d = array.Count / 2;
            while (d >= 1)
            {
                for (var i = d; i < array.Count; i++)
                {
                    var j = i;
                    while ((j >= d) && (array[j - d] > array[j]))
                    {
                        int fake = array[j];
                        array[j] = array[j - d];
                        array[j - d] = fake;
                        j = j - d;
                    }
                }
                d = d / 2;
            }
        }
    }
}
