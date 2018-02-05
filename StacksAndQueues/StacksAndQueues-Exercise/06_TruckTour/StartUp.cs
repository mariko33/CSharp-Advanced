using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_TruckTour
{
    class StartUp
    {
        static void Main()
        {
            int pumpNumbers = int.Parse(Console.ReadLine());
            
            var pumpInfo=new Queue<int[]>();
            for (int i = 0; i < pumpNumbers; i++)
            {
                pumpInfo.Enqueue(Console.ReadLine().Split().Select(int.Parse).ToArray());
            }

            for (int currentStart = 0; currentStart < pumpNumbers-1; currentStart++)
            {
                int fuel = 0;
                bool isSolution = true;
                for (int pumpPassed = 0; pumpPassed < pumpNumbers; pumpPassed++)
                {
                    var currPump = pumpInfo.Dequeue();
                    int pumpFuel = currPump[0];
                    int pumpDistance = currPump[1];
                    
                    pumpInfo.Enqueue(currPump);

                    fuel += pumpFuel - pumpDistance;

                    if (fuel<0)
                    {
                        currentStart += pumpPassed;
                        isSolution = false;
                        break;
                    }
                }
                if (isSolution)
                {
                    Console.WriteLine(currentStart);
                    Environment.Exit(0);
                }
            }
            
        }
    }
}
