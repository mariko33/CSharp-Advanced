using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_SequenceWithQueue
{
    class StartUp
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            Queue<long>temp=new Queue<long>();
            long[]result=new long[50];
            result[0] = number;
            temp.Enqueue(result[0]);
            
            for (int i = 1; i <result.Length-2; i+=3)
            {
                long curr = temp.Dequeue();
                result[i] = curr + 1;
                temp.Enqueue(result[i]);
                result[i + 1] = 2 * curr + 1;
                temp.Enqueue(result[i+1]);
                result[i + 2] = curr + 2;
                temp.Enqueue(result[i+2]);
                
            }
            if ((result.Length - 1) % 3 == 1) result[result.Length - 1] = (temp.Dequeue() + 1);
            if ((result.Length - 1) % 3 == 2)
            {
                long last = temp.Dequeue();
                result[result.Length - 2] = (last + 1);
                result[result.Length - 1] = 2*(last) + 1;
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
