using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Sort
    {
        //сортування злиттям
        public void MergeSort(List<Arc> array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                MergeSort(array, lowIndex, middleIndex);
                MergeSort(array, middleIndex + 1, highIndex);
                Merge(array, lowIndex, middleIndex, highIndex);
            }
        }
        //сортування вибором
        public void DoSelectionSort(List<Arc> array)
        {
            Arc minNumber;
            for (int i = 0; i < array.Count - 1; i++)
            {
                minNumber = array[i];

                for (int j = i + 1; j < array.Count; j++)
                {
                    if (minNumber.X_Degree == array[j].X_Degree)
                    {
                        minNumber = minNumber.Y_Degree < array[j].Y_Degree ? minNumber : array[j];
                    }
                    else
                        minNumber = minNumber.X_Degree < array[j].X_Degree ? minNumber : array[j];
                }
                //int index = Array.IndexOf(array, minNumber);
                int index = array.IndexOf(minNumber);
                array[index] = array[i];
                array[i] = minNumber;
            }
        }
        private void Merge(List<Arc> array, int lowIndex, int middleIndex, int highIndex)
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArray = new Arc[highIndex - lowIndex + 1];
            var index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (array[left].X_Degree == array[right].X_Degree)
                {
                    if (array[left].Y_Degree < array[right].Y_Degree)
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
                    if (array[left].X_Degree < array[right].X_Degree)
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
