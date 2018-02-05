using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_StringMatrixRotation
{
    class StartUp
    {
        static void Main()
        {
            var rotate = Console.ReadLine()
                .Split(new []{"(",")"},StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            int rotateDegree = int.Parse(rotate[1]);
            

            List<string> matrixString = new List<string>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                matrixString.Add(input);
            }

            int maxLength = 0;
            for (int i = 0; i < matrixString.Count; i++)
            {
                int currLength = matrixString[i].Length;
                if (currLength > maxLength)
                {
                    maxLength = currLength;
                }
            }

            var matrix = new char[matrixString.Count, maxLength];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col >= matrixString[row].Length)
                    {
                        matrix[row, col] = ' ';
                    }
                    else
                    {
                        matrix[row, col] = matrixString[row][col];
                    }
                }
            }

           if((rotateDegree%360)==270)Rotate270(matrix);
           else if ((rotateDegree % 360) == 180) Rotate180(matrix);
           else if ((rotateDegree%360) == 90) Rotate90(matrix);
           else if ((rotateDegree %360)== 0)
           {
               for (int row = 0; row < matrix.GetLength(0); row++)
               {
                   for (int col = 0; col < matrix.GetLength(1); col++)
                   {
                       
                       Console.Write(matrix[row, col]);
                    }
                   Console.WriteLine();
               }
           }
           

        }

        public static void Rotate180(char[,]matrix)
        {
            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                {
                    
                     Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }

        }


        public static void Rotate270(char[,]matrix)
        {
            for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    
                     Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static void Rotate90(char[,]matrix)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    
                     Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
