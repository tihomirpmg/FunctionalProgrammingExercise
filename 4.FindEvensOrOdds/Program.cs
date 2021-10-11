using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            string command = Console.ReadLine();

            Func<int[], List<int>> createList = CreateList;
            List<int> list = createList(bounds);
            Predicate<int> declare = n => n % 2 == 0;

            if (command == "odd")
            {
                declare = n => n % 2 != 0;
            }

            list = Mine(list, declare);
            Console.WriteLine(string.Join(' ', list));
        }

        private static List<int> Mine(List<int> list, Predicate<int> declare)
        {
            List<int> modified = new List<int>();
            foreach (var i in list)
            {
                if (declare(i))
                {
                    modified.Add(i);
                }
            }
            return modified;
        }

        private static List<int> CreateList(int[] bounds)
        {
            List<int> list = new List<int>();
            for (int i = bounds[0]; i <= bounds[1]; i++)
            {
                list.Add(i);
            }
            return list;
        }

        public static List<int> Finder(List<int> numbers, string command)
        {
            List<int> modified = new List<int>();
            switch (command)
            {
                case "even":
                    foreach (var item in numbers)
                    {
                        if (item % 2 == 0)
                        {
                            modified.Add(item);
                        }
                    }
                    break;
                case "odd":
                    foreach (var item in numbers)
                    {
                        if (item % 2 != 0)
                        {
                            modified.Add(item);
                        }
                    }
                    break;
                default:
                    return null;
            }
            return modified;
        }
    }
}