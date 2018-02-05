using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BasicStackOperations
{
    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(i => int.Parse(i))
                .ToArray();
            int numbersForPush = input[0];
            int numbersForDelete = input[1];
            int numberForFind = input[2];
            var arr = Console.ReadLine()
                .Split(' ')
                .Select(i=>int.Parse(i))
                .ToArray();
            Stack<int>stack=new Stack<int>(arr);
            if (numbersForPush == numbersForDelete)
            {
                Console.WriteLine(0);
                Environment.Exit(0);
            }
            for (int i = 0; i < numbersForDelete; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(numberForFind))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }

        }
    }
}
