using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SquareWithMaximumSum
{
    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            int[][]matrix=new int[input[0]][];
            for (int row = 0; row < input[0]; row++)
            {
                    matrix[row] = Console.ReadLine()
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray(); ;
                
            }

            int maxSum = int.MinValue;
            int[]pointMax=new int[2];
            for (int row = 0; row < matrix.Length-1; row++)
            {
                for (int col = 0; col < matrix[row].Length-1; col++)
                {
                    int currSum = matrix[row][col] + matrix[row][col + 1] + matrix[row + 1][col] +
                                 matrix[row + 1][col + 1];
                    if (currSum>maxSum)
                    {
                        maxSum = currSum;
                        pointMax[0] = row;
                        pointMax[1] = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[pointMax[0]][pointMax[1]]} {matrix[pointMax[0]][pointMax[1]+1]}");
            Console.WriteLine($"{matrix[pointMax[0]+1][pointMax[1]]} {matrix[pointMax[0]+1][pointMax[1]+1]}");
            Console.WriteLine(maxSum);
        }
    }
}
