using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_FindEvensOrOdds
{
    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var numbers=new List<int>();
            for (int i = input[0]; i <= input[1]; i++)
            {
                numbers.Add(i);
            }
            string condition = Console.ReadLine();

            Action<List<int>, string> print = (l, s) =>
            {
                if (s == "odd")
                {
                    foreach (var m in l.Where(x => x % 2 != 0))
                    {
                        Console.Write(m + " ");
                    }
                }

                else
                {
                    foreach (var m in l.Where(x => x % 2 == 0))
                    {
                        Console.Write(m + " ");
                    }
                }
            };

            print(numbers, condition);
        }
    }
}
