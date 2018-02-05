using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _04_MatchingBrackets
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var stack=new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                else if(input[i]==')')
                {
                    int inIndex = stack.Peek();
                    Console.WriteLine(input.Substring(stack.Pop(),i-inIndex+1));
                }
            }
        }
    }
}
