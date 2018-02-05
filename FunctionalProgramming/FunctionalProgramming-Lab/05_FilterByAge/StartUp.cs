using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _05_FilterByAge
{
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            Dictionary<string,int>people=new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                people.Add(input[0],int.Parse(input[1]));
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            var printCondition = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            
            switch (condition)
            {
                case "older":
                    var peopleCorect = people.Where(p => p.Value >= age).ToDictionary(p=>p.Key,p=>p.Value);
                    CreatePrintResult(printCondition,peopleCorect);
                    break;
                case "younger":
                    var peopleCorect2 = people.Where(p => p.Value < age).ToDictionary(p => p.Key, p => p.Value);
                    CreatePrintResult(printCondition,peopleCorect2);
                    break;


            }

        }

        private static void CreatePrintResult(string[] printCondition, Dictionary<string,int> people)
        {
            if (printCondition.Length==1)
            {
                switch (printCondition[0])
                {
                    case "name":
                        foreach (var p in people)
                        {
                            Console.WriteLine(p.Key);
                        }
                        break;
                    case "age":
                        foreach (var p in people)
                        {
                            Console.WriteLine(p.Value);
                        }
                        break;
                }
            }
            else
            {
                foreach (var p in people)
                {
                    Console.WriteLine($"{p.Key} - {p.Value}");
                }
            }
        }
    }
    
}
