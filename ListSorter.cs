using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList
{
    public class ListSorter
    {
        private ISort[] sorts = new ISort[] { new BubbleSort(), new InsertSort(), new QuickSort() };
        private Random sortsRandomizer = new Random();
        
        /// <summary>
        /// Функция сортировки массива. Алгоритм сортировки выбирается случайным образом из: "Метод пузырька","Метод вставки","Быстрая сортировка"
        /// </summary>
        /// <param name="unsortedList">Неотсортированный массив System.Int32[]</param>
        /// <returns>Сортированный массив System.Int32[]</returns>
        public void SortList(int[] unsortedList)
        {
            int variant = sortsRandomizer.Next(0, sorts.Length);
            sorts[variant].Sort(unsortedList);
        }
    }
}
