using System;
using System.Linq;

namespace _12.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Func<string, int> asciiSumOnName = n => n.Select(j => (int)j).Sum();

            Func<string[], int, Func<string, int>, string> nameFunction = (names, n, function) => names.FirstOrDefault(k => function(k) >= n);
            Console.WriteLine(nameFunction(names, n, asciiSumOnName));
        }
    }
}