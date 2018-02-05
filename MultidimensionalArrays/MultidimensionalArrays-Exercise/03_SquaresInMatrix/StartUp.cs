using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SquaresInMatrix
{
    class StartUp
    {
        static void Main()
        {
            var sizeArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            string [][] matrix=new String[sizeArr[0]][];
            for (int i = 0; i < sizeArr[0]; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(' ');

            }
            int numberSquares = 0;

            for (int row = 0; row < matrix.Length-1; row++)
            {
                for (int col = 0; col < matrix[row].Length-1; col++)
                {
                    if (matrix[row][col]==matrix[row][col+1]&& 
                        matrix[row][col] == matrix[row+1][col]&& matrix[row][col] == matrix[row+1][col+1])
                    {
                        numberSquares++;
                    }
                }
            }
            Console.WriteLine(numberSquares);

        }

    }
}
