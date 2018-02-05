using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_PredicateParty_
{
    class StartUp
    {
        static void Main()
        {
            var guestsList = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<string, string, bool> startsWith = (string name, string str) => name.StartsWith(str);
            Func<string, string, bool> endsWith = (string name, string str) => name.EndsWith(str);
            Func<string, int, bool> length = (string name, int len) => name.Length==len;


            string input;
            while ((input=Console.ReadLine())!= "Party!")
            {
                var commands = input.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (commands[0])
                {
                    case "Remove":
                        switch (commands[1])
                        {
                            case "StartsWith":
                                guestsList.RemoveAll(g => startsWith(g, commands[2]));
                                break;
                            case "EndsWith":
                                guestsList.RemoveAll(g => endsWith(g, commands[2]));
                                break;
                            case "Length":
                                guestsList.RemoveAll(g => length(g, int.Parse(commands[2])));
                                break;
                        }
                        break;
                    case "Double":
                        switch (commands[1])
                        {
                            case "StartsWith":
                                var currList = guestsList.Where(g => startsWith(g, commands[2])).ToList();
                                guestsList.AddRange(currList);             
                                break;
                            case "EndsWith":
                                var currList2 = guestsList.Where(g => endsWith(g, commands[2])).ToList();
                                guestsList.AddRange(currList2);
                                break;
                            case "Length":
                                var currList3 = guestsList.Where(g => length(g, int.Parse(commands[2]))).ToList();
                                guestsList.AddRange(currList3);
                                break;
                        }
                        break;
                }
             

            }


            if (guestsList.Count == 0) Console.WriteLine("Nobody is going to the party!");
            else
            {
                Dictionary<string,int>results=guestsList.GroupBy(x=>x).ToDictionary(g=>g.Key,g=>g.Count());
                List<string>finalResult=new List<string>();
                foreach (var pair in results)
                {
                    for (int i = 0; i < pair.Value; i++)
                    {
                       finalResult.Add(pair.Key);
                    }
                }
                Console.WriteLine($"{string.Join(", ",finalResult)} are going to the party!");
            }
        }
    }
}
