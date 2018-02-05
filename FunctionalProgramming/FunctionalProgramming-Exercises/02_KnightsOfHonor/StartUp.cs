using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_KnightsOfHonor
{
    class StartUp
    {
        static void Main()
        {
            var names = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Action<string> print = x => Console.WriteLine($"Sir {x}");
            
            foreach (var name in names)
            {
                print(name);
            }
        }
    }
}
