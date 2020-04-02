namespace Lab1
{
    public class Sort
    {
        public void BubleSort(int[] array)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                for (int j = 0; j < array.Length - 1; ++j)
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
        public void ShellaSort(int[] array)
        {
            var d = array.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < array.Length; i++)
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
