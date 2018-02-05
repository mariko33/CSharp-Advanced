
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _11_ThePartyReservationFilterModule
{
    class StartUp
    {
        static void Main()
        {
            var guestsList = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<string, string, bool> startsWith = (string name, string str) => name.StartsWith(str);
            Func<string, string, bool> endsWith = (string name, string str) => name.EndsWith(str);
            Func<string, int, bool> length = (string name, int len) => name.Length == len;
            Func<string, string, bool> contains = (string name, string str) => name.Contains(str);
            Func< string, string,string, bool> filterType =
                ( string filter, string param, string name) =>
                {
                    switch (filter)
                    {
                        case "Starts with":
                            return startsWith(name, param);
                            break;
                        case "Ends with":
                            return endsWith(name, param);
                            break;
                        case "Length":
                            return length(name,int.Parse(param));
                            break;
                        case "Contains":
                            return contains(name,param);
                            break;
                           default:
                               return true;
                               break;
                    }

                };

            
            bool isRunning = true;
            List<string> result = guestsList.Select(x=>x).ToList();
            while (isRunning)
            {
                var commands = Console.ReadLine().Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                switch (commands[0])
                {
                    case "Add filter":
                        result.RemoveAll(r=>filterType(commands[1],commands[2],r));
                        break;
                    case "Remove filter":
                        result.AddRange(guestsList.Where(g=>filterType(commands[1],commands[2],g)));
                        break;
                    case "Print":
                        foreach (var g in guestsList)
                        {
                            if (result.Contains(g))
                            {
                                Console.Write(g+" ");
                            }
                        }
                        isRunning = false;
                        break;
                }
            }
        }
    }
}
