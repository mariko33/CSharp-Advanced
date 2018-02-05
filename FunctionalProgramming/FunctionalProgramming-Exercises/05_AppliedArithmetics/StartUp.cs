using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_AppliedArithmetics
{
    class StartUp
    {
        static void Main()
        {
            Action<List<int>, string> arithmetics = (numbers, condition) =>
            {
                switch (condition)
                {
                    case "add":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            numbers[i] += 1;
                        }
                        break;
                    case "multiply":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            numbers[i] *= 2;
                        }
                        break;
                    case "subtract":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            numbers[i] -= 1;
                        }
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ",numbers));
                        break;
                }
            };
            var inputNumbers = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string inputCondition;
            while ((inputCondition=Console.ReadLine())!="end")
            {
                arithmetics(inputNumbers, inputCondition);
            }

        }
    }
}
