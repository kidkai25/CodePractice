using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> l  = new List<int>[] { 4, 5, 2, 1 };
            var x = new int[] { 892599, 557543, 351931, 28539, 914656, 226726, 255449, 750741, 807018, 754851, 461978, 503963, 670830, 543588, 783085, 902220, 892934, 783097, 777077, 297312, 881986, 939694, 230760, 58103, 93541, 436890, 651916, 511113, 425460, 579016, 934683, 373773, 366190, 16028, 560664, 325276, 663537, 838668, 236788, 464923, 92876, 318889, 492084, 207073, 761207, 217917, 701331, 654295, 851964, 838377, 786795, 981896, 558708, 717973, 65230, 670142, 984233, 92776, 372940, 248992, 60888, 926786, 621678, 849972, 141580, 4284, 511055, 657900, 169605, 411442, 375293, 487428, 246453, 303333 };
            var y = new int[] { 960435, 469562, 405444, 741272, 29763, 923470, 616544, 809077, 525521, 829276, 834301, 954592, 927708, 432064, 450407, 715286, 726201, 831853, 143722, 501222, 886968, 655046, 131292, 678097, 84782, 168884, 437696, 539466, 477830, 588513, 640937, 514810, 932188, 397158, 425992, 841880, 577217, 457738, 27436, 952706, 469180, 124308, 638834, 118943, 451584, 829357, 586928, 392838, 528190, 118124, 572503, 796518, 58713, 73756, 563199, 731385, 250039, 971896, 282224, 406121, 651859, 490091, 929474, 283927, 548880, 72607, 359619, 613327, 261651, 325524, 672437, 138659, 380023, 528060, 335010, 339589, 184688, 642091, 159211, 680411, 564531, 868161, 730660, 631338, 682033, 559082, 384605, 646474, 812902, 633297, 883040, 621673, 228385 };
            int[] r = new int[y.Length];
            r = AnswerQueries(x, y);
            Console.ReadLine();
        }

        public static  int[] AnswerQueries(int[] nums, int[] queries)
        {
            int n = nums.Length;
            int powerSet = 1 << n;
            //var ans = new int[queries.Length];
            List<List<decimal>> ans = new List<List<decimal>>();
            int[] result = new int[queries.Length];
            List<int> result2 = new List<int>();

            for(int setMask = 0; setMask <powerSet; setMask++)
            {
                List<decimal> t = new List<decimal>();
                for(int i = n - 1; i >= 0; i--)
                {
                    if ((setMask & (1 << i)) > 0)
                    {
                        t.Add(nums[i]);
                    }
                }
                ans.Add(t);
                

            }


            foreach(var a in queries)
            {
                var maxCount = 0;
                foreach (var x in ans)
                {
                    if (x.Count == 11)
                    {
                        var ii = 0;
                    }
                    var r = x.Sum();
                    if (r <= a)
                    {
                        if (maxCount < x.Count)
                        {
                            maxCount = x.Count;
                        }

                        //break;
                    }
                   
                }
                result2.Add(maxCount);
            }

            //foreach(var x in ans)
            //{
            //    foreach(var y in x)
            //    {
            //        Console.Write(y);
            //    }
            //    Console.WriteLine();
            //}
            return result2.ToArray();
            //return null;
        }
    }
}
