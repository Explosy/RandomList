using System;

namespace RandomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу RandomListGenerator");
            
            RandomListGenerator randomListGenerator = new RandomListGenerator();
            ListSorter listSorter = new ListSorter();
            ListSender listSender = new ListSender();
            int[] randomList = new int[0];
            
            while (true)
            {
                Console.Clear();
                PrintList(randomList);
                Console.WriteLine("Выберите нужное действие:");
                Console.WriteLine("1 - Сформировать новую последовательность случайных чисел");
                Console.WriteLine("2 - Отсортировать текущую последовательность");
                Console.WriteLine("3 - Отправить последовательность на сервер");
                Console.WriteLine("0 - Выход из программы");
                var pressedKey = Console.ReadKey(true);
                switch (char.ToLower(pressedKey.KeyChar))
                {
                    case '1':
                        randomList = randomListGenerator.GetRandomList(20);
                        break;
                    case '2':
                        listSorter.Sort(randomList);
                        break;
                    case '3':
                        listSender.Send(randomList);
                        break;
                    case '0':
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Выполнение программы закончено");
                            Console.ForegroundColor = ConsoleColor.White;
                            return;
                        }
                }
            }
            
        }

        static void PrintList(int[] array)
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
    }
}
