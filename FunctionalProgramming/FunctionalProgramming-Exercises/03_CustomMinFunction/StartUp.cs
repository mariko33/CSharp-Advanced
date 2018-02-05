using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CustomMinFunction
{
    class StartUp
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            Func<List<int>, int> minNumber = l => l.Min();
            Console.WriteLine(minNumber(numbers));
        }
    }
}
