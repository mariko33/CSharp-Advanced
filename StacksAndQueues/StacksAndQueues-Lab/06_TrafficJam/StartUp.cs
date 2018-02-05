using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_TrafficJam
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int nPassingTheJam = int.Parse(Console.ReadLine());
            string input;
            Queue<string>cars=new Queue<string>();
            int numbersAllPassed = 0;
            while ((input=Console.ReadLine())!="end")
            {
                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else
                {
                    int count;
                    if (nPassingTheJam > cars.Count) count = cars.Count;
                    else count = nPassingTheJam;
                    
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        numbersAllPassed++;
                    }
                }
                
            }
            Console.WriteLine($"{numbersAllPassed} cars passed the crossroads.");
        }
    }
}
