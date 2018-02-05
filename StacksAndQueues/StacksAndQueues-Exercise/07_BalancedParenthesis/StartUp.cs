using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_BalancedParenthesis
{
    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine().ToCharArray();
            var opened=new char[]{ '{','(','['};
            var closed = new char[] {'}', ')', ']'};
            Stack<char>openedStack=new Stack<char>();
            if (input.Length%2!=0)
            {
                Console.WriteLine("NO");
                Environment.Exit(0);
            }
          
            for (int i = 0; i < input.Length; i++)
            {
                if (opened.Contains(input[i]))
                {
                    openedStack.Push(input[i]);
                }
                else
                {
                    int closedIndex = Array.IndexOf(closed, input[i]);
                    int openedIndex = Array.IndexOf(opened, openedStack.Pop());
                    if (closedIndex != openedIndex)
                    {
                        Console.WriteLine("NO");
                        Environment.Exit(0);
                    }
                }
               
            }
            Console.WriteLine("YES");

        }
    }
}
