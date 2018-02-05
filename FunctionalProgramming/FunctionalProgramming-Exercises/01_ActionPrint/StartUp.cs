using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01_ActionPrint
{
    class StartUp
    {
        static void Main()
        {
            Action<string> print = s => Console.WriteLine(s);
            var names = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            foreach (var name in names)
            {
                print(name);
            }
        }
    }
}
