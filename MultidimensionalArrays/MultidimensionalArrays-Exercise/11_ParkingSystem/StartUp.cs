using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ParkingSystem
{
    class StartUp
    {
        static void Main()
        {
            Dictionary<int,HashSet<int>>parking=new Dictionary<int, HashSet<int>>();
            int[] data = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int totalRows = data[0];
            int totalCols = data[1];
            string input;

            while ((input=Console.ReadLine())!="stop")
            {
                string[] dataForCarPark = input.Split();
                int entryRow = int.Parse(dataForCarPark[0]);
                int tagetRow = int.Parse(dataForCarPark[1]);
                int targetCol = int.Parse(dataForCarPark[2]);

                if (!IsPlaceOccupied(parking, tagetRow, targetCol))
                {
                    OccupyPlace(parking, tagetRow, targetCol);

                    int distance = Math.Abs(entryRow - tagetRow);
                    distance += targetCol + 1;
                    Console.WriteLine(distance);
                }
                else
                {
                    targetCol = TryFindEmptySpace(parking[tagetRow], totalCols, targetCol);
                    if (targetCol == 0)
                    {
                        Console.WriteLine($"Row {tagetRow} full");
                    }
                    else
                    {
                        OccupyPlace(parking, tagetRow, targetCol);

                        int distance = Math.Abs(entryRow - tagetRow);
                        distance += targetCol + 1;
                        Console.WriteLine(distance);
                    }
                }

            }

        }

        private static int TryFindEmptySpace(HashSet<int> hashSet,int totalNumberOfCols, int targetCol)
        {
            int targetColIndex = 0;
            int minDistance = int.MaxValue;
            
            if (hashSet.Count == totalNumberOfCols - 1)
            {
                return targetColIndex;
            }
            else
            {
                for (int i = 1; i < totalNumberOfCols; i++)
                {
                    int currentDistance = Math.Abs(targetCol - i);
                    
                    if (!hashSet.Contains(i)&&currentDistance<minDistance)
                    {
                        targetColIndex = i;
                        minDistance = currentDistance;
                        
                    }
                }
                return targetColIndex;
            }
        }


        public static bool IsPlaceOccupied(Dictionary<int, HashSet<int>>parking, int targetRow,int targetCol)
        {
            return parking.ContainsKey(targetRow) && parking[targetRow].Contains(targetCol);
        }

        public static void OccupyPlace(Dictionary<int, HashSet<int>> parking, int targetRow, int targetCol)
        {
            if (!parking.ContainsKey(targetRow))
            {
                parking.Add(targetRow,new HashSet<int>());
            }

            parking[targetRow].Add(targetCol);
        }
    }
}
