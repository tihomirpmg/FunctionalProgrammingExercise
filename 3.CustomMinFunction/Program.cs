using System;
using System.Linq;

namespace _3.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            Func<int[], int> minN = GetMin;
            Console.WriteLine(minN(nums));
        }
        public static int GetMin(int[] nums)
        {
            int min = int.MaxValue;

            foreach (var n in nums)
            {
                if (min > n)
                {
                    min = n;
                }
            }
            return min;
        }
    }
}
