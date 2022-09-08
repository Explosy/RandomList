namespace RandomList
{
    /// <summary>
    /// Класс реализующий сортировку массива методом вставки
    /// </summary>
    internal class InsertSort : ISort
    {
        public void Sort(int[] array)
        {
            int temp;
            int index;
            for (int i = 0; i < array.Length; i++)
            {
                temp = array[i];
                index = i;

                while (index > 0 && temp < array[index - 1])
                {
                    array[index] = array[index - 1];
                    index--;
                }
                array[index] = temp;
            }
        }
    }
}
