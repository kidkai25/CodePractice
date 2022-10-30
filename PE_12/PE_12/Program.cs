using System;
using System.Collections.Generic;
using System.Linq;

namespace PE_12
{
    //Program to create N Triangle Numbers
    class Program
    {
        static void Main(string[] args)
        {
            bool found = false;

            foreach (var num in TriangleNumbers())
            {
                Console.WriteLine(num);
                if(num == 76576500) { 
                    
                    Console.WriteLine("Found" + num);
                    //break;
                        }

                //Get d
                long d = GetTNDivisors(num);
                Console.WriteLine("Current d" + d);
                if (d > 500)
                {
                    Console.WriteLine(num);
                    found = true;
                    break;
                }


                if (found)
                    break;

            }


        }

        static IEnumerable<long> TriangleNumbers(long n = 0)
        {
            long counter = 0;
            long i = 1;
            long tn = 0;

            //for(; counter != n; i++,counter++)
            //{                
            //    tn += i;
            //    yield return tn;
            //}
            while(true)
            {
                tn += i;
                yield return tn;
                i++;
            }

        }

        static long GetTNDivisors(long N)
        {
            List<long> d = new List<long>();

            for(int i  = 1; i <= N; i++)
            {
                if(N % i == 0)                
                    d.Add(i);
                
            }

            return d.Count();
        }
    }
}
