using System.Collections.Generic;

namespace Lab1
{
    class Sorting
    {
        //Сортування вставкою
        public void InsertionSort(List<int> array)
        {
            int i, j;
            for (i = 0; i < array.Count; i++)
            {
                int fakeStone = array[i];
                for (j = i - 1; j >= 0 && array[j] > fakeStone; j--)
                    array[j + 1] = array[j];

                array[j + 1] = fakeStone;
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
