using System;
using System.Configuration;

namespace RandomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу RandomListGenerator");
            
            RandomListGenerator randomListGenerator = new RandomListGenerator();
            ListSorter listSorter = new ListSorter();
            string serverURL = ConfigurationManager.AppSettings.Get("ServerURL");
            ListSender listSender = new ListSender(serverURL);
            int[] randomList = new int[0];
            
            while (true)
            {
                ProgramInterface.PrintMainMenu(randomList);
                var pressedKey = Console.ReadKey(true);
                switch (char.ToLower(pressedKey.KeyChar))
                {
                    case '1':
                        ProgramInterface.PrintGenerationMenu();
                        int count = GetCount();
                        randomList = randomListGenerator.GetRandomList(count);
                        break;
                    case '2':
                        listSorter.Sort(randomList);
                        break;
                    case '3':
                        bool flag = listSender.Send(randomList);
                        ProgramInterface.PrintSendResult(flag);
                        break;
                    case '0':
                        {
                            ProgramInterface.PrintExit();
                            return;
                        }
                }
            }
            
        }
        /// <summary>
        /// Метод получения от пользователя количества необходимых чисел в последовательности
        /// </summary>
        /// <returns></returns>
        private static int GetCount()
        {
            while (true)
            {
                string number = Console.ReadLine();
                int count;
                if (int.TryParse(number, out count))
                {
                    if (count >= 20 && count <= 100)
                        return count;
                }
                Console.WriteLine("Ошибка ввода. Попробуйте еще раз");
            }
   
        }
    }
}
