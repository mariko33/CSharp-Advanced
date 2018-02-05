using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_TargetPractice
{
    class StartUp
    {
        
        public static void Main()
        {
            var sizeArr = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            int rows = sizeArr[0];
            int cols = sizeArr[1];
            string snakes = Console.ReadLine();
            
            var shot = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            
            int cellRow = shot[0];
            int cellCol = shot[1];
            int radius = shot[2];
            
        

            char[,]matrix=new char[rows,cols];
            
            FillMatrix(rows,cols,snakes,matrix);

          
            GetShot(matrix, cellRow,cellCol,radius);

            for (int col = 0; col < cols; col++)
            {
                GetFill(col,matrix);
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }

        }

        private static void GetFill(int colIndex, char[,] matrix)
        {
            while (true)
            {
                bool isEmpty = false;
                for (int rowIndex = 1; rowIndex < matrix.GetLength(0); rowIndex++)
                {
                    if (matrix[rowIndex,colIndex] == ' ' && matrix[rowIndex - 1,colIndex] != ' ')
                    {
                        matrix[rowIndex, colIndex] = matrix[rowIndex - 1, colIndex];
                        matrix[rowIndex - 1, colIndex] = ' ';
                        isEmpty = true;
                    }

                }

                if (!isEmpty)
                {
                    break;
                }


            }
            
        }

        private static void GetShot(char[,] matrix, int cellRow, int cellCol, int radius)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((i - cellRow) * (i - cellRow) + (j - cellCol) * (j - cellCol) <= radius * radius)
                    {
                        matrix[i, j] = ' ';
                    }
                }
            }
        }


        public static void FillMatrix(int rows, int cols, string snakes, char[,]matrix)
        {
            
            bool isLeft = true;
            int index = 0;
            for (int rowsIndex = rows-1; rowsIndex >=0; rowsIndex--)
            {
                if (isLeft)
                {
                    for (int colsIndex = cols-1; colsIndex >=0; colsIndex--)
                    {
                        if (index>=snakes.Length)
                        {
                            index = 0;
                        }
                        matrix[rowsIndex, colsIndex] = snakes[index];
                        index++;
                    }
                }
                else
                {
                    for (int colsIndex = 0; colsIndex < cols; colsIndex++)
                    {
                        if (index >= snakes.Length)
                        {
                            index = 0;
                        }
                        matrix[rowsIndex, colsIndex] = snakes[index];
                        index++;
                    }
                }
                isLeft = !isLeft;
            }
            
        }
    }
}
