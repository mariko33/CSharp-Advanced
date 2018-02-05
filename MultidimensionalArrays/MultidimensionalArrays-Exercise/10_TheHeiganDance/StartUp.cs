using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_TheHeiganDance
{
    class StartUp
    {
        public static  double playerPoints = 18500;
        public static  double heiganPoints = 3000000;
        //public const int cloudDamage = 3500;
        //public const int eruptionDemage = 6000;

        static void Main()
        {
            var chamber = new int[15, 15];
            var playerPosition = new[] {7, 7};
            string lastDamage = String.Empty;
            
            double heiganDemages = double.Parse(Console.ReadLine());
            
            while (true)
            {
                var input = Console.ReadLine().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
                string spell = input[0];
                int rowDemage = int.Parse(input[1]);
                int colDemage = int.Parse(input[2]);
                
                DeamgeArea(rowDemage,colDemage,chamber);

                heiganPoints -= heiganDemages;
                if (lastDamage == "Cloud") playerPoints -= 3500;
                
                if(playerPoints<=0||heiganPoints<=0)break;

                if (chamber[playerPosition[0], playerPosition[1]] == 1)
                {
                    if (playerPosition[0] - 1 >=0 && chamber[playerPosition[0] - 1, playerPosition[1]] == 0)
                    {
                        playerPosition[0]--;
                        lastDamage=String.Empty;
                    }
                    else if (playerPosition[1] + 1 <= 14 && chamber[playerPosition[0], playerPosition[1] + 1] == 0)
                    {
                        playerPosition[1]++;
                        lastDamage = String.Empty;

                    }
                    else if (playerPosition[0] + 1 <= 14 && chamber[playerPosition[0] + 1, playerPosition[1]] == 0)
                    {
                        playerPosition[0]++;
                        lastDamage = String.Empty;
                    }
                    else if(playerPosition[1]-1>=0&&chamber[playerPosition[0],playerPosition[1]-1]==0)
                    {
                        playerPosition[1]--;
                        lastDamage = String.Empty;
                    }
                    else
                    {
                        if (spell == "Cloud") playerPoints -= 3500;
                        else  playerPoints -= 6000;
                        lastDamage = spell;
                        
                    }
                }

                for (int i = 0; i < chamber.GetLength(0); i++)
                {
                    for (int j = 0; j < chamber.GetLength(1); j++)
                    {
                        chamber[i, j] = 0;
                    }
                }
                if(playerPoints<=0){break;}

            }

            if (heiganPoints<=0){ Console.WriteLine("Heigan: Defeated!");}
            else{ Console.WriteLine($"Heigan: {heiganPoints:f2}");}
            if (playerPoints <= 0)
            {
                if (lastDamage == "Cloud") lastDamage = "Plague Cloud";
                Console.WriteLine($"Player: Killed by {lastDamage}");
            }
            else {Console.WriteLine($"Player: {playerPoints}");}

            Console.WriteLine($"Final position: {playerPosition[0]}, {playerPosition[1]}");
          
        }

       

        public static void DeamgeArea(int rowDemage, int colDemage, int[,] matrix)
        {
            int startRow = rowDemage - 1;
            int endRow = rowDemage + 1;
            int startCol = colDemage - 1;
            int endCol = colDemage + 1;
            
            if (startRow < 0) startRow = 0;
            if (endRow > 14) endRow = 14;
            if (startCol < 0) startCol = 0;
            if (endCol > 14) endCol = 14;

            for (int row = startRow; row <= endRow; row++)
            {
                for (int col = startCol; col <= endCol; col++)
                {
                    matrix[row, col] = 1;

                }
            }

            
        }
       
    }
}
