using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            string cmd;

            while ((cmd = Console.ReadLine()) != "Party!")
            {
                string cmd1 = cmd.Split()[0];
                string cmd2 = cmd.Split()[1];
                string act = cmd.Split()[2];

                var predicate = GetPredicate(cmd2, act);

                switch (cmd1)
                {
                    case "Remove": names.RemoveAll(predicate); 
                        break; 
                    case "Double":
                        List<string> matches = names.FindAll(predicate);

                        if (matches.Count > 0)
                        {
                            int insertIndex = names.FindIndex(predicate);
                            names.InsertRange(insertIndex, matches);
                        }

                        break;
                    default: 
                        break;
                }
            }

            if (names.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }

        }

        public static Predicate<string> GetPredicate(string cmd2, string act)
        {
            switch (cmd2)
            {
                case "StartsWith": return n => n.StartsWith(act);
                case "EndsWith": return n => n.EndsWith(act);
                case "Length": return n => n.Length == int.Parse(act);
                default: 
                    return null;
            }
        }
    }
}