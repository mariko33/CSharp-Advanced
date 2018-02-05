using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CountUppercaseWords
{
    class StartUp
    {
        static void Main()
        {
            var words = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            foreach (var s in words.Where(w=>char.IsUpper(w[0])))
            {
                Console.WriteLine(s);
            }
        }
    }
}
