using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_SimpleTextEditor
{
    class StartUp
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
            var stack=new Stack<string>();
            StringBuilder str=new StringBuilder();
            for (int i = 0; i < numbers; i++)
            {
                var input = Console.ReadLine()
                    .Split().ToArray();
                int command = int.Parse(input[0]);
                switch (command)
                {
                    case 1:
                        stack.Push(str.ToString());
                        str.Append(input[1]);
                        break;
                    case 2:
                        stack.Push(str.ToString());
                        str.Remove(str.Length-int.Parse(input[1]), int.Parse(input[1]));
                        break;
                    case 3:
                        Console.WriteLine(str[int.Parse(input[1])-1]);
                        break;
                    case 4:
                        str.Clear();
                        str.Append(stack.Pop());
                        break;
                        
                }

            }
        }
    }
}
