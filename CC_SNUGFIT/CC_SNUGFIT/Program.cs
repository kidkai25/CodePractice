using System;
using System.Linq;

namespace CC_SNUGFIT
{
    class Program
    {
        static void Main(string[] args)
        {
            int tc = int.Parse(Console.ReadLine());

            while(tc-- > 0)
            {
                int N = int.Parse(Console.ReadLine());

                var l1 = Array.ConvertAll(Console.ReadLine().Split(), x => long.Parse(x));
                l1 = l1.OrderBy(x => x).ToArray();


                var l2 = Array.ConvertAll(Console.ReadLine().Split(), x => long.Parse(x));
                l2 = l2.OrderBy(x => x).ToArray();

                //Thinking of comparing min of both
                var l3 = l1.Zip(l2, (x1, x2) => {
                    return x1 > x2 ? x2 : x1;                
                });

                Console.WriteLine(l3.Sum());
               
            }

            Console.ReadLine();


        }
    }
}
