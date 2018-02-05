using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ReverseStrings
{
   public class StartUp
    {
       public static void Main()
       {
           var input = Console.ReadLine();
           var stack=new Stack<char>();
           for (int i = 0; i < input.Length; i++)
           {
               stack.Push(input[i]);
           }
           string result = "";
           while (stack.Count!=0)
           {
               result += stack.Pop();
           }
           Console.WriteLine(result);
       }
    }
}
