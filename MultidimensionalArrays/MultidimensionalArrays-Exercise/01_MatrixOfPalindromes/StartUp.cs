using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MatrixOfPalindromes
{
    class StartUp
    {
        static void Main()
        {
            var inputArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            
            string[,]matrix=new String[inputArr[0],inputArr[1]];
            var alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
               
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                  
                    matrix[row, col] = alphabet[row].ToString() + alphabet[row+col] + alphabet[row];

                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
