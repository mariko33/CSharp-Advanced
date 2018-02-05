using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_MaximalSum
{
    class StartUp
    {
        static void Main()
        {
            var sizes = Console.ReadLine()
                .Split(new []{" "},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix=new int[sizes[0],sizes[1]];
            
            for (int row = 0; row < sizes[0]; row++)
            {
                int[] current = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < sizes[1]; col++)
                {
                    matrix[row, col] = current[col];
                }

            }

            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;
            
            for (int row = 0; row < matrix.GetLength(0)-2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-2; col++)
                {
                    int currSum = matrix[row,col] + matrix[row,col + 1] + matrix[row,col + 2] +
                                  matrix[row + 1,col] + matrix[row + 1,col + 1] + matrix[row + 1,col + 2] +
                                  matrix[row + 2,col] + matrix[row + 2,col + 1] + matrix[row + 2,col + 2];
                    if (currSum>maxSum)
                    {
                        maxSum = currSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
                
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int row = maxRow; row < maxRow+3; row++)
            {
                for (int col = maxCol; col < maxCol+3; col++)
                {
                    Console.Write(matrix[row,col]+" ");
                }
                Console.WriteLine();
            }
        }
        
        
    }
}
