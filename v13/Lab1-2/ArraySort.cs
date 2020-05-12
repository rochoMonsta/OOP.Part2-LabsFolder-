using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class ArraySort
    {
        //Сортування вставкою
        public void InsertionSort(List<int> stones)
        {
            int i, j;
            for (i = 0; i < stones.Count; i++)
            {
                int fakeStone = stones[i];
                for (j = i - 1; j >= 0 && stones[j] > fakeStone; j--)
                    stones[j + 1] = stones[j];

                stones[j + 1] = fakeStone;
            }
        }
        //Швидке сорутвання
        public void QuickSort(List<int> array, int minIndex, int maxIndex)
        {
            if (!(minIndex >= maxIndex))
            {
                var pivotIndex = Partition(array, minIndex, maxIndex);
                QuickSort(array, minIndex, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, maxIndex);
            }
        }
        private void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }
        private int Partition(List<int> array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    int random_number = array[pivot];
                    array[pivot] = array[i];
                    array[i] = random_number;
                }
            }
            pivot++;
            int random_number1 = array[pivot];
            array[pivot] = array[maxIndex];
            array[maxIndex] = random_number1;
            return pivot;
        }
    }
}
