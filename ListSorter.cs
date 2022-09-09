using System;

namespace RandomList
{
    /// <summary>
    /// Класс сортировщик массивов. Сортировка производится путем вызова метода Sort()
    /// </summary>
    public class ListSorter
    {
        private ISort[] sorts;
        private Random sortsRandomizer;
        
        private ISort GetAlgorithm => sorts[sortsRandomizer.Next(0, sorts.Length)];

        public ListSorter()
        {
            sorts = new ISort[] { new BubbleSort(), new InsertSort(), new QuickSort() };
            sortsRandomizer = new Random();
        }

        /// <summary>
        /// Функция сортировки массива. Алгоритм сортировки выбирается случайным образом из: "Метод пузырька","Метод вставки","Быстрая сортировка"
        /// </summary>
        /// <param name="unsortedList">Неотсортированный массив</param>
        public void Sort(int[] unsortedList)
        {
            var sortAlgorithm = GetAlgorithm;
            sortAlgorithm.Sort(unsortedList);
        }
    }
}
