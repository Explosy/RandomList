using System;

namespace RandomList
{
    /// <summary>
    /// Класс реализующий интерфейс программы
    /// </summary>
    internal static class ProgramInterface
    {
        /// <summary>
        /// Метод вывода основного меню программы
        /// </summary>
        /// <param name="array">Массив чисел для вывода их на экран</param>
        public static void PrintMainMenu(int[] array)
        {
            Console.Clear();
            PrintList(array);
            Console.WriteLine("Выберите нужное действие:");
            Console.WriteLine("1 - Сформировать новую последовательность случайных чисел");
            Console.WriteLine("2 - Отсортировать текущую последовательность");
            Console.WriteLine("3 - Отправить последовательность на сервер");
            Console.WriteLine("0 - Выход из программы");
        }

        /// <summary>
        /// Метод вывода меню генерации последовательности
        /// </summary>
        public static void PrintGenerationMenu()
        {
            Console.Clear();
            Console.WriteLine("Введите количество чисел в последовательности (в диапазоне [20;100]):");
        }

        /// <summary>
        /// Метод вывода последовательности чисел на экран
        /// </summary>
        /// <param name="array"></param>
        private static void PrintList(int[] array)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Текущая последовательность чисел:");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Метод вывода результатов отправки
        /// </summary>
        /// <param name="flag"></param>
        public static void PrintSendResult(bool flag)
        {
            if (flag)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Отправка прошла успешно.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Во время отправки возникли ошибки. Попробуйте еще раз или измените адрес сервера в настройках.");
                Console.ForegroundColor = ConsoleColor.White;
            } 
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }

        public static void PrintExit()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Выполнение программы закончено");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
