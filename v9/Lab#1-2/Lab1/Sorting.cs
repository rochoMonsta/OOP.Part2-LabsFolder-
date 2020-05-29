using System.Collections.Generic;

namespace Lab1
{
    class Sorting
    {
        //сортування злиттям
        public void MergeSort(List<int> array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                MergeSort(array, lowIndex, middleIndex);
                MergeSort(array, middleIndex + 1, highIndex);
                Merge(array, lowIndex, middleIndex, highIndex);
            }
        }
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
        private void Merge(List<int> array, int lowIndex, int middleIndex, int highIndex)
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArray = new int[highIndex - lowIndex + 1];
            var index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (array[left] == array[right])
                {
                    if (array[left] < array[right])
                    {
                        tempArray[index] = array[left];
                        left++;
                    }
                    else
                    {
                        tempArray[index] = array[right];
                        right++;
                    }
                }
                else
                {
                    if (array[left] < array[right])
                    {
                        tempArray[index] = array[left];
                        left++;
                    }
                    else
                    {
                        tempArray[index] = array[right];
                        right++;
                    }
                }
                index++;
            }
            for (var i = left; i <= middleIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }
            for (var i = right; i <= highIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }
            for (var i = 0; i < tempArray.Length; i++)
            {
                array[lowIndex + i] = tempArray[i];
            }
        }
    }
}
