using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> selectE = n => n % 2 == 0;
            Predicate<int> selectO = n => n % 2 != 0;

            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Func<int[], Predicate<int>, List<int>> function = EvenOROdd;

            List<int> listEven = function(array, selectE);
            List<int> listOdd = function(array, selectO);
            listEven.Sort();
            listOdd.Sort();

            int count = listOdd.Count;
            for (int i = 0; i < count; i++)
            {
                listEven.Add(listOdd[i]);
            }
            Console.WriteLine(string.Join(' ', listEven));

        }
        private static List<int> EvenOROdd(int[] array, Predicate<int> predicate)
        {
            List<int> nums = new List<int>();
            foreach (var item in array)
            {
                if (predicate(item))
                {
                    nums.Add(item);
                }
            }
            return nums;
        }
    }
}