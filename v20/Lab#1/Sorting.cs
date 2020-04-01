﻿namespace Lab1
{
    class Sorting
    {
        //Сортування вставкою
        public void InsertionSort(Stone[] stones)
        {
            int i, j;
            for (i = 0; i < stones.Length; i++)
            {
                Stone fakeStone = stones[i];
                for (j = i - 1; j >= 0 && stones[j].StoneWeight > fakeStone.StoneWeight; j--)
                    stones[j + 1] = stones[j];

                stones[j + 1] = fakeStone;
            }
        }
        private void Merge(Stone[] array, int lowIndex, int middleIndex, int highIndex)
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArray = new Stone[highIndex - lowIndex + 1];
            var index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (array[left].StoneWeight < array[right].StoneWeight)
                {
                    tempArray[index] = array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    right++;
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

        //сортування злиттям
        public void MergeSort(Stone[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                MergeSort(array, lowIndex, middleIndex);
                MergeSort(array, middleIndex + 1, highIndex);
                Merge(array, lowIndex, middleIndex, highIndex);
            }
        }
    }
}