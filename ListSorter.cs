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
            InsertSort(unsortedList);
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
        
        /// <summary>
        /// Быстрая сортировка массива
        /// </summary>
        /// <param name="array">Неотсортированный массив</param>
        private int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex) return array;

            int pivot = FindPivot(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivot - 1);
            QuickSort(array, pivot + 1, maxIndex);

            return array;
        }
        private int FindPivot (int[] array, int minIndex, int maxIndex)
        {
            int pivot = minIndex -1;
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
