using System.Collections.Generic;

namespace Lab1
{
    class Sort
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
        //сортування змішуванням
        public void ShakerSort(List<int> array)
        {
            for (var i = 0; i < array.Count / 2; i++)
            {
                var swapFlag = false;
                //прохід зліва направо
                for (var j = i; j < array.Count - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int box = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = box;
                        swapFlag = true;
                    }
                }
                //прохід справа наліво
                for (var j = array.Count - 2 - i; j > i; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        int box = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = box;
                        swapFlag = true;
                    }
                }
                //якщо обмінів не було
                if (!swapFlag)
                {
                    break;
                }
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
