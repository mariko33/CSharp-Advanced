using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ReverseNumbers
{
    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            Stack<string>stack=new Stack<string>(input);
            Console.WriteLine(string.Join(" ",stack));
            
        }
    }
}
