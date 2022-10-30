using System;
using System.Linq;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new int[] { 2, 1, 6, 3, 5 };
            x = x.OrderBy(x => x)
                 .ToArray();

            Console.WriteLine(String.Join(",", x));
            Console.ReadLine();
            
        }

        
    }
}
