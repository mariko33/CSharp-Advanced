using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_RadioactiveBunnies
{
    class StartUp
    {
        static void Main()
        {
            var sizes = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = sizes[0];
            int cols = sizes[1];
            char[][]matrix=new Char[rows][];
            int[]sizePerson=new int[2];
            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                matrix[rowIndex] = Console.ReadLine().ToCharArray();

                if (matrix[rowIndex].Contains('P'))
                {
                    int colIndex = Array.IndexOf(matrix[rowIndex], 'P');
                    sizePerson[0] = rowIndex;
                    sizePerson[1] = colIndex;
                    matrix[sizePerson[0]][sizePerson[1]] = '.';
                }
            }

            char[] commands = Console.ReadLine().ToCharArray();
            bool isWon = false;
            
            for (int i = 0; i < commands.Length; i++)
            {
                int tempRow = sizePerson[0];
                int tempCol = sizePerson[1];
                
                GetMove(commands[i], sizePerson);
                SpreadBunny(matrix,cols);

                if (sizePerson[0] < 0 || sizePerson[0] >= rows || sizePerson[1] < 0 || sizePerson[1] >= cols)
                {
                    sizePerson[0] = tempRow;
                    sizePerson[1] = tempCol;
                    isWon = true;
                    break;
                }

                if (matrix[sizePerson[0]][sizePerson[1]]=='B')
                {
                    break;
                }
                
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("",row));
            }
            
            if(isWon) Console.WriteLine($"won: {sizePerson[0]} {sizePerson[1]}");
            else Console.WriteLine($"dead: {sizePerson[0]} {sizePerson[1]}");
        }

        public static void GetMove(char command, int[] size)
        {
            switch (command)
            {
                case 'L':
                    size[1] -= 1;
                    break;
                case 'R':
                    size[1] += 1;
                    break;
                case 'U':
                    size[0] -= 1;
                    break;
                case 'D':
                    size[0] += 1;
                    break;

            }
        }

        public static void SpreadBunny(char[][] matrix,int cols)
        {
            var bCoordinates=new List<List<int>>();
            
            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                for (int colIndex = 0; colIndex < cols; colIndex++)
                {
                    if (matrix[rowIndex][colIndex]=='B')
                    {
                        var coordinates=new List<int>
                        {
                            rowIndex,
                            colIndex
                        };
                        bCoordinates.Add(coordinates);
                        

                    }
                }
            }

            foreach (var coordinates in bCoordinates)
            {
                if (0 <= (coordinates[0] - 1) && (coordinates[0] - 1) < matrix.Length) matrix[coordinates[0] - 1][coordinates[1]] = 'B';
                if (0 <= (coordinates[0] + 1) && (coordinates[0] + 1) < matrix.Length) matrix[coordinates[0] + 1][coordinates[1]] = 'B';
                if (0 <= (coordinates[1] - 1) && (coordinates[1] - 1) < cols) matrix[coordinates[0]][coordinates[1] - 1] = 'B';
                if (0 <= (coordinates[1] + 1) && (coordinates[1] + 1) < cols) matrix[coordinates[0]][coordinates[1] + 1] = 'B';
            }
        }
    }
}
