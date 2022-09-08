using System;

namespace RandomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу RandomListGenerator");
            RandomListGenerator randomListGenerator = new RandomListGenerator();
            var newRandomList = randomListGenerator.GetRandomList(20);
            ListSorter listSorter = new ListSorter();
            listSorter.SortList(newRandomList);
            foreach(var item in newRandomList)
            {
                Console.Write(item + " ");
            }
        }
    }
}
