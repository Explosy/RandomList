namespace RandomList
{
    /// <summary>
    /// Класс реализующий "Быструю сортировку" массива
    /// </summary>
    internal class QuickSort : ISort
    {
        public void Sort(int[] array)
        {
            QSort(array, 0, array.Length-1);
        }

        private void QSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex) return;

            int pivot = FindPivot(array, minIndex, maxIndex);
            QSort(array, minIndex, pivot - 1);
            QSort(array, pivot + 1, maxIndex);
        }
        private int FindPivot(int[] array, int minIndex, int maxIndex)
        {
            int pivot = minIndex - 1;
            int temp;

            for (int i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    temp = array[pivot];
                    array[pivot] = array[i];
                    array[i] = temp;
                }
            }

            pivot++;
            temp = array[pivot];
            array[pivot] = array[maxIndex];
            array[maxIndex] = temp;

            return pivot;
        }
    }
}
