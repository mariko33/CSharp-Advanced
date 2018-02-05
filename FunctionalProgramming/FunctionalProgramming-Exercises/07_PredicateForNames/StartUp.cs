using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_PredicateForNames
{
    class StartUp
    {
        static void Main()
        {
            Action<List<string>, int> print = (names, n) => Console.WriteLine(string.Join(Environment.NewLine,
                names.Where(x => x.Length <= n).ToList()));

            int inputN = int.Parse(Console.ReadLine());
            var inputNames = Console.ReadLine().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries).ToList();
            print(inputNames, inputN);
        }
    }
}
