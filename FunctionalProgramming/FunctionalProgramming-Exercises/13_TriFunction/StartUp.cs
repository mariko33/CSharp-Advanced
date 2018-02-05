using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_TriFunction
{
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            var inputList = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            
            Func<string, int> sumOfCharacter = (string name) => name.Sum(n=>(int)n);
            Func<string, int, bool> isEqualOrLarger = (string name, int num) => sumOfCharacter(name) >= num;
            
            Console.WriteLine(inputList.FirstOrDefault(i=>isEqualOrLarger(i,number)));

        }
    }
}
