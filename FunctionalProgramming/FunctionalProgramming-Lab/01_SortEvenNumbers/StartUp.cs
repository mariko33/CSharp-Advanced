using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SortEvenNumbers
{
    class StartUp
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(n => n % 2 == 0)
                .ToList()
                .OrderBy(n=>n);

            Console.WriteLine(string.Join(", ", numbers));
        }

    }
}
