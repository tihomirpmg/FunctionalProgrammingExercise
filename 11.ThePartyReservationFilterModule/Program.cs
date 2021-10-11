using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> listOfCmds = new List<string>();

            string cmd;

            while ((cmd = Console.ReadLine()) != "Print")
            {
                string[] tokens = cmd.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "Add filter")
                {
                    listOfCmds.Add($"{tokens[1]} {tokens[2]}");
                }
                else
                {
                    listOfCmds.Remove($"{tokens[1]} {tokens[2]}");
                }
            }

            foreach (var item in listOfCmds)
            {
                string[] selectCmd = item.Split();

                switch (selectCmd[0])
                {
                    case "Starts":
                        names = names.Where(n => !n.StartsWith(selectCmd[2])).ToList();
                        break;
                    case "Ends":
                        names = names.Where(n => !n.EndsWith(selectCmd[2])).ToList();
                        break;
                    case "Length":
                        names = names.Where(n => n.Length != int.Parse(selectCmd[1])).ToList();
                        break;
                    case "Contains":
                        names = names.Where(n => !n.Contains(selectCmd[1])).ToList();
                        break;
                }
            }
            Console.WriteLine(string.Join(' ', names));
        }
    }
}