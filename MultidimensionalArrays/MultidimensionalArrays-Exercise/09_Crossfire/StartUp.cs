using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _09_Crossfire
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
            var matrix = new List<List<int>>();
            int counter = 1;
            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                var currList = new List<int>();
                for (int colIndex = 0; colIndex < cols; colIndex++)
                {
                    
                    currList.Add(counter++);
                    
                }
                matrix.Add(currList);
            }

            string commandArr;
            while ((commandArr=Console.ReadLine())!= "Nuke it from orbit")
            {
                var commands = commandArr.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                    .ToArray();
                int row = commands[0];
                int col = commands[1];
                int radius = commands[2];
                
                DestroyMatrix(row,col,radius,matrix);      

            }

            foreach (var row in matrix)
            {
                
                    Console.WriteLine(string.Join(" ", row));
                
               
            }
        }

        public static void DestroyMatrix(int row, int col, int radius,List<List<int>>matrix)
        {
            
            //up and down
            for (int rowNew = row-Math.Abs(radius); rowNew <= row+Math.Abs(radius); rowNew++)
            {
                if (isIndexesIsValid(rowNew,col,matrix))
                {
                    matrix[rowNew][col] = 0;
                }
            }
            
            //left right
            for (int colNew = col-Math.Abs(radius); colNew <=col+Math.Abs(radius); colNew++)
            {
                if (isIndexesIsValid(row, colNew, matrix))
                {
                    matrix[row][colNew] = 0;
                }

                
            }

            for (int r = 0; r < matrix.Count; r++)
            {
                matrix[r].RemoveAll(x => x == 0);
                if (matrix[r].Count == 0)
                {
                    matrix.RemoveAt(r);
                    r--;
                }
            }



        }

        public static bool isIndexesIsValid(int row, int col, List<List<int>> matrix)
        {
            return row >= 0 && row < matrix.Count && col >= 0 && col < matrix[row].Count;

        }
    }
}
