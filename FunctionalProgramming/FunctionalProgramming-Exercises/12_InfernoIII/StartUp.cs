
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;

namespace _12_InfernoIII
{
    class StartUp
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Func<int, int, int, bool> sumLeft = (int num, int previos, int sum) => num + previos == sum;
            Func<int, int, int, bool> sumRight = (int num, int next, int sum) => num + next == sum;
            Func<int, int, int,int, bool> sumLeftRight = (int num, int previos,int next, int sum) => num + previos+next == sum;

            List<int>excludeList=new List<int>();

            string input;
            while ((input=Console.ReadLine())!= "Forge")
            {
                var commands = input.Split(new[] {";"}, StringSplitOptions.RemoveEmptyEntries);

                switch (commands[0])
                {
                    case "Exclude":

                        switch (commands[1])
                        {
                            case "Sum Left":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    int previous = 0;
                                    if (i != 0)
                                    {
                                        previous = numbers[i-1];

                                    }
                                    if (sumLeft(numbers[i], previous, int.Parse(commands[2])))
                                    {
                                        excludeList.Add(numbers[i]);
                                    }
                                }
                                 break;
                            case "Sum Right":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    int next = 0;
                                    if (i != numbers.Count - 1)
                                    {
                                        next = numbers[i + 1];

                                    }
                                    if (sumRight(numbers[i], next, int.Parse(commands[2])))
                                    {
                                        excludeList.Add(numbers[i]);
                                    }
                                }
                                break;
                            case "Sum Left Right":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    int previous = 0;
                                    int next = 0;
                                    if (i != 0)
                                    {
                                        previous = numbers[i - 1];

                                    }
                                    if (i != numbers.Count - 1)
                                    {
                                        next = numbers[i + 1];
                                    }
                                    if (sumLeftRight(numbers[i], previous, next, int.Parse(commands[2])))
                                    {
                                        excludeList.Add(numbers[i]);
                                    }
                                }
                                break;

                        }
                        break;
                    case "Reverse":

                        switch (commands[1])
                        {
                            case "Sum Left":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    int previous = 0;
                                    if (i != 0)
                                    {
                                        previous = numbers[i - 1];

                                    }
                                    if (sumLeft(numbers[i], previous, int.Parse(commands[2])))
                                    {
                                        excludeList.Remove(numbers[i]);
                                    }
                                }
                                break;
                            case "Sum Right":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    int next = 0;
                                    if (i != numbers.Count - 1)
                                    {
                                        next = numbers[i + 1];

                                    }
                                    if (sumRight(numbers[i], next, int.Parse(commands[2])))
                                    {
                                        excludeList.Remove(numbers[i]);
                                    }
                                }
                                break;
                            case "Sum Left Right":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    int previous = 0;
                                    int next = 0;
                                    if (i != 0)
                                    {
                                        previous = numbers[i - 1];

                                    }
                                    if (i != numbers.Count - 1)
                                    {
                                        next = numbers[i + 1];
                                    }
                                    if (sumLeftRight(numbers[i], previous, next, int.Parse(commands[2])))
                                    {
                                        excludeList.Remove(numbers[i]);
                                    }
                                }
                                break;
                        }
                        break;

                }
                
            }

            foreach (var num in numbers)
            {
                if (!excludeList.Contains(num))
                {
                    Console.Write(num+" ");
                }
            }

        }
    }
}
