using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SimpleCalculator
{
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var stack=new Stack<string>(input.Split(' ').Reverse());
            while (stack.Count>1)
            {
                string first = stack.Pop();
                string operand = stack.Pop();
                string second = stack.Pop();
                switch (operand)
                {
                    case "+":stack.Push((int.Parse(first)+int.Parse(second)).ToString());
                        break;
                    case "-":stack.Push((int.Parse(first)-int.Parse(second)).ToString());
                        break;
                }
            }
            
            Console.WriteLine(stack.Pop());

        }
    }
}
