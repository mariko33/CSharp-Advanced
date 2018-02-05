using System;
using System.Collections.Generic;
using System.Linq;


namespace _06_ReverseAndExclude
{
    class StartUp
    {
        static void Main()
        {
            Func<List<int>, int, List<int>> reverceEndExclude = (numbers, n) => numbers.Where(x => x % n != 0).Reverse().ToList();

            var inputNumbers = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int inputN = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(" ",reverceEndExclude(inputNumbers,inputN)));

        }
    }
}
