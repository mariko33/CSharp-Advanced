using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DiagonalDifference
{
    class StartUp
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[][] square=new int[size][];
            for (int i = 0; i < size; i++)
            {
                square[i] = Console.ReadLine()
                    .Split(new []{" "},StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray(); 
                
            }
            long leftDiagonal = 0;
            long rightDiagonal = 0;
            for (int i = 0; i < square.Length; i++)
            {
                leftDiagonal += square[i][i];
                rightDiagonal += square[i][square.Length - 1 - i];
            }


            Console.WriteLine(Math.Abs(leftDiagonal-rightDiagonal));
        }
    }
}
