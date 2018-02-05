using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SumMatrixElements
{
    class StartUp
    {
        static void Main()
        {

            var input = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[,] matrix=new int[input[0],input[1]];
            int sum = 0;
            for (int row = 0; row < input[0]; row++)
            {
                var arr = Console.ReadLine().Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < input[1]; col++)
                {
                    matrix[row,col] = arr[col];
                    sum += matrix[row, col];
                }
            }

            Console.WriteLine(input[0]);
            Console.WriteLine(input[1]);
            Console.WriteLine(sum);
        }
    }
}
