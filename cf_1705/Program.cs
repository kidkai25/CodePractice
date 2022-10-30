using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cf_1705
{
    class Program
    {
        static void Main(string[] args)
        {
            int tc = Convert.ToInt16(Console.ReadLine());

            while(tc-- > 0)
            {
                string input = Console.ReadLine();
                //size 2
                int[] n = input.Split(' ').Select(x => int.Parse(x)).ToArray();
                int people = 2 * n[0];
                int minHeight = n[1];

                int[] pH = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                //SORT
                Array.Sort(pH);

                var g1 = pH.TakeWhile((x, ind) => ind < (people / 2)).ToList();
                var g2 = pH.SkipWhile((x, ind) => ind < (people / 2)).ToList();

                int i = 0;
                //a loop
                for (; i < (people/2); i++)
                {
                    var diff = g2[i] - g1[i];
                    if (diff < minHeight)
                        break;                         
                }
                if( i != people/2 )
                    Console.WriteLine("NO");
                else
                    Console.WriteLine("YES");

                ; 
            }
        }
    }
}
