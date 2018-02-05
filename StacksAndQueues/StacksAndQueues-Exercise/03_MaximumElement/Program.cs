using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MaximumElement
{
    class Program
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
            Stack<int>stack=new Stack<int>();
            Stack<int>stackMax=new Stack<int>();
            stackMax.Push(int.MinValue);
            for (int i = 0; i <numbers; i++)
            {
                var query = Console.ReadLine()
                    .Split(' ')
                    .Select(q => int.Parse(q))
                    .ToArray();
                switch (query[0])
                {
                    case 1:stack.Push(query[1]);
                        if(query[1]>=stackMax.Peek())stackMax.Push(query[1]);
                        break;
                    case 2:
                        if (stackMax.Peek()==stack.Peek())
                        {
                            stack.Pop();
                            stackMax.Pop();
                        }
                        else
                        {
                            stack.Pop();
                        }
                        break;
                    case 3:
                        Console.WriteLine(stackMax.Peek());
                        break;
                }
            }
        }
    }
}
