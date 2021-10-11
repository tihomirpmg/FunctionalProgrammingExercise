using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int upLimit = int.Parse(Console.ReadLine());
            List<int> list = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Distinct().ToList();
            HashSet<int> nums = new HashSet<int>();

            for (int i = 1; i <= upLimit; i++)
            {
                bool valid = true;

                foreach (int item in list)
                {
                    Func<int, int, bool> select = (i, item) =>
                    {
                        return i % item == 0;
                    };

                    if (select(i, item) == false)
                    {
                        valid = false;
                        break;
                    }
                }

                if (valid)
                {
                    nums.Add(i);
                }
            }
            Console.WriteLine(string.Join(' ', nums));
        }
    }
}