using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Reverse().ToList();
            int n = int.Parse(Console.ReadLine());
            Func<List<int>, int, List<int>> numSelect = NumSelection;
            Console.WriteLine(string.Join(' ', numSelect(list, n)));
        }
        private static List<int> NumSelection(List<int> nums, int n)
        {
            List<int> modify = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % n != 0)
                {
                    modify.Add(nums[i]);
                }
            }
            return modify;
        }
    }
}
