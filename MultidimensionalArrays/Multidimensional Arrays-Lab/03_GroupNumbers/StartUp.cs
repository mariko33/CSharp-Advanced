using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GroupNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            //another way
            //var listZeros = input.Where(i => Math.Abs(i) % 3 == 0).ToList();
            //var listOnes= input.Where(i => Math.Abs(i) % 3 == 1).ToList();
            //var listTwos= input.Where(i => Math.Abs(i) % 3 == 2).ToList();
            //Console.WriteLine(string.Join(" ",listZeros));
            //Console.WriteLine(string.Join(" ", listOnes));
            //Console.WriteLine(string.Join(" ", listTwos));



            int[]sizes=new int[3];

            foreach (var number in input)
            {
                int reminder = Math.Abs(number) % 3;
                sizes[reminder]++;
            }
            
            int[][]matrix=
            {
                new int[sizes[0]],
                new int[sizes[1]],
                new int[sizes[2]] 
                
            };
            int index0 = 0;
            int index1 = 0;
            int index2 = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int row = Math.Abs(input[i]) % 3;
                if (row==0)
                {
                    matrix[row][index0] = input[i];
                    index0 ++;
                }
                else if (row == 1)
                {
                    matrix[row][index1] = input[i];
                    index1++;
                    
                }
                else
                {
                    matrix[row][index2] = input[i];
                    index2++;
                }
                
                
            }
            

            for (int row = 0; row < matrix.Length; row++)
            {
                Console.WriteLine(string.Join(" ",matrix[row]));
            }
        }
    }
}
