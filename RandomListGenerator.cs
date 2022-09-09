using System;

namespace RandomList
{
    /// <summary>
    /// Класс реализующий генерацию последовательности случайных чисел
    /// </summary>
    internal class RandomListGenerator
    {
        private Random itemGenerator;
        private int randomMinimum;
        private int randomMaximum;

        /// <summary>
        /// Создание генератора массива случайных чисел (по умолчанию в диапазоне от -100 до 100)
        /// </summary>
        public RandomListGenerator()
        {
            itemGenerator = new Random();
            randomMaximum = 101;
            randomMinimum = -100;
        }
        
        /// <summary>
        /// Создание генератора массива случайных чисел в диапазоне от randomMinimum до randomMaximum
        /// </summary>
        /// <param name="randomMinimum">Нижняя граница диапазона генерации</param>
        /// <param name="randomMaximum">Верхняя граница диапазона генерации</param>
        public RandomListGenerator(int randomMinimum, int randomMaximum)
        {
            itemGenerator = new Random();
            this.randomMaximum = randomMinimum;
            this.randomMinimum = randomMaximum;
        }

        /// <summary>
        /// Генерация случайной последовательности заданной длины
        /// </summary>
        /// <param name="size">Размер выходной последовательности</param>
        public int[] GetRandomList (int size)
        {
            int[] result = new int[size];
            for (int index = 0; index < size; index++)
            {
                result[index] = itemGenerator.Next(randomMinimum, randomMaximum);
            }
            return result;
        }
    }
}
