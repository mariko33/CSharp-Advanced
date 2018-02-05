using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_BasicQueueOperations
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
                .Select(i => int.Parse(i))
                .ToArray();
            Queue<int> queue = new Queue<int>(arr);
            if (numbersForPush == numbersForDelete)
            {
                Console.WriteLine(0);
                Environment.Exit(0);
            }
            for (int i = 0; i < numbersForDelete; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(numberForFind))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
