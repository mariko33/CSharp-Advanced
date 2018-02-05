using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_LegoBlocks
{
    class StartUp
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            
            int[][]leftMatrix=new int[rows][];
            int[][]rightMatrix=new int[rows][];
            
            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                leftMatrix[rowIndex] = Console.ReadLine()
                    .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }
            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                rightMatrix[rowIndex] = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .Reverse()
                    .ToArray();
            }

            int count = 0;
            int[][] resultMatrix=new int[rows][];
            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                resultMatrix[rowIndex] = leftMatrix[rowIndex].Concat(rightMatrix[rowIndex]).ToArray();
                count += resultMatrix[rowIndex].Length;

            }

            bool isFit = true;

            int resultLength = resultMatrix[0].Length;

            for (int rowIndex = 1; rowIndex < resultMatrix.Length; rowIndex++)
            {
                if (resultMatrix[rowIndex].Length!=resultLength)
                {
                    isFit = false;
                }
            }
              
            
            if (isFit)
            {
                foreach (var arr in resultMatrix)
                {
                    Console.WriteLine($"[{string.Join(", ", arr)}]");
                    
                }
            }
            else
            {
                Console.WriteLine($"The total number of cells is: {count}");
            }

            
            
            
        }
    }
}
