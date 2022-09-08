using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList
{
    public class ListSorter
    {
        /// <summary>
        /// Функция сортировки массива. Алгоритм сортировки выбирается случайным образом из: "","",""
        /// </summary>
        /// <param name="unsortedList">Неотсортированный массив System.Int32[]</param>
        /// <returns>Сортированный массив System.Int32[]</returns>
        public void SortList(int[] unsortedList)
        {
            BubbleSort(unsortedList);
        }
        /// <summary>
        /// Сортировка массива пузырьком
        /// </summary>
        /// <param name="array">Неотсортированный массив</param>
        /// <returns></returns>
        private void BubbleSort(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }
                }
            }
        }
        /// <summary>
        /// Сортировка массива методом вставки
        /// </summary>
        /// <param name="array">Неотсортированный массив</param>
        private void InsertSort(int[] array)
        {
            int temp;
            int index;
            for (int i = 0; i < array.Length; i++)
            {
                temp = array[i];
                index = i;

                while (index > 0 && temp < array[index-1])
                {
                    array[index] = array[index - 1];
                    index--;
                }
                array[index] = temp;
            }
        }

    }
}
