using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DecimalToBinaryConverter
{
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var values = input.Split().Select(s=>int.Parse(s)).ToArray();
            var stack=new Stack<int>();
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i]==0)
                {
                    stack.Push(0);
                }
                else
                {
                    while (values[i]>0)
                    {
                        stack.Push(values[i] % 2);
                        values[i] = values[i] / 2;
                    }
                }
                
                
            }
            while (stack.Count>0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
