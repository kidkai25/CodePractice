using System;
using System.Linq;

namespace CC_LECANDY_ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {

            int testCase = int.Parse(Console.ReadLine());

            while (testCase-- > 0)
            {

                int N = int.Parse(Console.ReadLine());
                int[] workers = Array.ConvertAll(Console.ReadLine().Split(), x => int.Parse(x));

                //Find min and max salary between the workers
                int turns = 0;

                Array.Sort(workers);
                int sm = workers[0];

                int net = 0;

                for (int i = 0; i < workers.Length; i++)
                {
                    net += (workers[i] - sm);
                }

                //while(workers.Distinct().Count() != 1) {
                //    Array.Sort(workers);
                //    Array.Reverse(workers);
                //    turns++;

                //    for(int i = 1; i < workers.Length; i++)
                //    {
                //        workers[i] += 1;
                //    }
                //}

                Console.WriteLine(net);
            }

        }
    }
}
