using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _08_RecursiveFibonacci
{
    class StartUp
    {
        private static long[] fibonacciNumbers;
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            fibonacciNumbers = new long[n];
            long result = getFibonacci(n);
            Console.WriteLine(result);
        }

        private static long getFibonacci(int i)
        {
            if (i <= 2) return 1;
            if (fibonacciNumbers[i - 1] != 0) return fibonacciNumbers[i - 1];
            return fibonacciNumbers[i - 1] = getFibonacci(i - 1) + getFibonacci(i - 2);
        }
    }
}
