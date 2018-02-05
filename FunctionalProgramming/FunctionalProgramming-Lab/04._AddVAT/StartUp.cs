using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._AddVAT
{
    class StartUp
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries);

            Func<string, double> parser = x => double.Parse(x);
            Func<double, double> addVat = x => x + x * 0.2;
            foreach (var d in numbers
                .Select(parser)
                .Select(addVat))
            {
                Console.WriteLine($"{d:f2}");
            }
        }
    }
}

