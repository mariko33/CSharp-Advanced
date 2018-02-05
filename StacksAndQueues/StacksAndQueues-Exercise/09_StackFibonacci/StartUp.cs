using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StackFibonacci
{
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Stack<long>fibonacciStack=new Stack<long>();
            fibonacciStack.Push(0);
            fibonacciStack.Push(1);
            fibonacciStack.Push(1);
            if (number==0)
            {
                fibonacciStack.Pop();
                Console.WriteLine(fibonacciStack.Peek());
                Environment.Exit(0);
            }
            if (number<=2)
            {
                Console.WriteLine(fibonacciStack.Peek());
                Environment.Exit(0);
            }
            for (int i = 2; i < number; i++)
            {
                long fibonacciSecond = fibonacciStack.Pop();
                long fibonacciFirst = fibonacciStack.Pop();
                long currNumber = fibonacciFirst + fibonacciSecond;
                fibonacciStack.Push(fibonacciSecond);
                fibonacciStack.Push(currNumber);
            }
            Console.WriteLine(fibonacciStack.Peek());
            
        }
    }
}
