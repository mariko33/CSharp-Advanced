using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_PascalTriangle
{
    class StartUp
    {
        static void Main()
        {
            var height = int.Parse(Console.ReadLine());
            
            long[][]pascalTriangle=new long[height][];
            
            for (int row = 0; row < height; row++)
            {
                pascalTriangle[row]=new long[row+1];
                pascalTriangle[row][0] = 1;
                pascalTriangle[row][pascalTriangle[row].Length - 1] = 1;
                if (pascalTriangle[row].Length>2)
                {
                    for (int col = 1; col < pascalTriangle[row].Length-1; col++)
                    {
                        pascalTriangle[row][col] = pascalTriangle[row - 1][col - 1] + pascalTriangle[row - 1][col];
                    }
                }
            }

            foreach (var row in pascalTriangle)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }
    }
}
