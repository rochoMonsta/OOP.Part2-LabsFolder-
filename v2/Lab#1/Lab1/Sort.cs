namespace Lab1
{
    class Sort
    {
        //Сортування вставками
        public void InsertionSort(int[] array, int count)
        {
            for (int i = 1; i < count; i++)
            {
                int cur = array[i];
                int j = i;
                while (j > 0 && cur < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = cur;
            }
        }
        //Швидке сорутвання
        public void QuickSort(int[] array, int minIndex, int maxIndex)
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
        private int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }
            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }
    }
}
