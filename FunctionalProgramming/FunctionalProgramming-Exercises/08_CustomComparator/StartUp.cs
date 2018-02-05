
using System;
using System.Linq;


namespace _08_CustomComparator
{
    class StartUp
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Console.WriteLine(string.Join(" ",Array.Sort(numbers)));
        }

        
    }

    public static class Array
    {
        public static int[] Sort(this int[] numbers)
        {
           
             var oddArr=  numbers
               .OrderBy(x => x)
                .Where(x=>x%2==0)
                .ToArray();
            var evenArr = numbers
                .OrderBy(x => x)
                .Where(x => x % 2 != 0)
                .ToArray();
            return oddArr.Concat(evenArr).ToArray();
        }
    }
}
