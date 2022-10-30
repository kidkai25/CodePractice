using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a hashset
            //var x = new HashSet<int>();
            List<int> A = new List<int> { 100, 4, 200, 1, 3, 2 };
            A = new List<int> { 1,2,-2,4,-4 };

            A = new List<int> { 1, 2, -3, 3 };

            A = new List<int> { 10, -3, -9, -10, 9, -26, 7, -2, -20, -19, -9, 7, 13, -5, -8, -24, -11, 28, 28, 24 };
            
            //var ip = new double[] { 1, 2, 3 };
            // double sum = 0;
            long sum = 0;
            var preFixSum = A.Select(x => sum += x).ToList<long>();


            A = new List<int> { 1, 2, 1, 3, 4, 3 };
            A = new List<int> { 45, 45, 3, 3, 3, 45, 45, 45, 45, 3, 3, 3, 3, 3, 3, 45, 45, 45, 45, 3, 3, 45, 3, 45, 3 };
            int B = 3;
            B = 5;


            //long L = -1;
            //long R = -1;            
            //Dictionary<long, long> d = new Dictionary<long, long>();
            //d.Add(0, -1);
            //long maxD = long.MinValue;
            //for (int i = 0; i < A.Count; i++)
            //{
            //    var val = preFixSum[i];
            //    if(d.ContainsKey(val))
            //    {
            //        long index = d[val];
            //        long cd = Math.Abs(i - index);

            //        if(cd > maxD)
            //        {
            //            L = index;
            //            R = i;
            //            maxD = cd;
            //        }                    
            //    }
            //    else
            //    {
            //        d.Add(val, i);
            //    }
            //}


            //if (maxD != int.MinValue)
            //{
            //    if (L == -1)
            //    {
            //        var r = A.GetRange(0, (int)R+1);
            //    }
            //    else
            //    {
            //        var r = A.GetRange((int)L + 1, (int)R - (int)L);
            //    }
            //    // var x = r;
            //}
            //    Console.WriteLine("found");

            //var output = ip.Select(w => sum += w).ToList();
            //Console.WriteLine();
            //var l1 = output.ToList();
            //var l2 = output.ToList();
            var result = Solve(A,B);
            //var k = -2;
           // Console.WriteLine(result);
            Console.ReadLine();
        }

        public static List<int> Solve(List<int> A, int B)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            List<int> result = new List<int>(B);
            int dc = 0;
            
            //traverse first window
            for(int  i = 0; i < B; i++)
            {
                if(!dic.ContainsKey(A[i]))
                {
                    dic.Add(A[i], 1);
                    dc++;
                }
                else
                {
                    int count = dic[A[i]];
                    dic.Remove(A[i]);
                    dic.Add(A[i], count + 1);
                }
            }
            result.Add(dc);

            //traversing rest of the window
            for (int i = B; i < A.Count; i++)
            {
                if (dic.ContainsKey(A[i - B]))
                {
                    if (dic[A[i - B]] == 1)
                    {
                        dic.Remove(A[i - B]);
                        dc--;
                    }
                    else
                    {
                        int key = i - B;
                        int count = dic[A[key]];
                        dic.Remove(A[key]);
                        dic.Add(A[key], count - 1);
                    }
                }


                    if (!dic.ContainsKey(A[i])) //doesn't contain
                    {
                        dic.Add(A[i], 1);
                        dc++;
                    }
                    else
                    {
                        int count = dic[A[i]];
                    dic.Remove(A[i]);
                        dic.Add(A[i], count + 1);
                        //dc++;
                    }

                    result.Add(dc);
            }
            return result;
        }
        public static List<int> Solve5(List<int> A, int B)
        {
            HashSet<int> hs = new HashSet<int>(B);
            List<int> result = new List<int>(B);
            //i = 0
            //for (int i = 0; i < B; i++)
            //{
            //    hs.Add(A[i]);
            //}
            //result.Add(hs.Count);
            //hs.Clear();
            //rest of them
            for(int i = 0; i < A.Count - B + 1; i++)
            {
                
                for (int j = 0; j < B; j++)
                {
                    //int r = A[i - B]; 
                    int a = A[i + j];
                    //hs.Remove(r);
                    hs.Add(a);
                }

                result.Add(hs.Count);

                hs.Clear();
            }

            return result;

        }
        public static List<int> Solve4(List<int> A)
        {
            long sum = 0;
            var preFixSum = A.Select(x => sum += x).ToList<long>();

            var r = new List<int>(A.Count);

            long L = -1;
            long R = -1;
            Dictionary<long, long> d = new Dictionary<long, long>();
            d.Add(0, -1);
            long maxD = long.MinValue;
            for (int i = 0; i < A.Count; i++)
            {
                var val = preFixSum[i];
                if (d.ContainsKey(val))
                {
                    long index = d[val];
                    long cd = Math.Abs(i - index);

                    if (cd > maxD)
                    {
                        L = index;
                        R = i;
                        maxD = cd;
                    }
                }
                else
                {
                    d.Add(val, i);
                }
            }


            if (maxD != int.MinValue)
            {
                if (L == -1)
                {
                     r = A.GetRange(0, (int)R + 1);
                }
                else
                {
                     r = A.GetRange((int)L + 1, (int)R - (int)L);
                }
                // var x = r;
            }
            //return new List<int> { };
            return r;
        }
        public static int Solve3(List<int> A)
        {
            //calculate prefix sum and then find duplicate
            List<int> preFixSum = new List<int>(A.Count);

            preFixSum.Add(A[0]);
            var hs = new HashSet<int>(A.Count);
            hs.Add(A[0]);
            for (int i = 1; i < A.Count; i++)
            {
                preFixSum.Add(A[i] + preFixSum[i - 1]);
                int val = preFixSum[i];
                if (hs.Contains(val))
                    return 1;
                hs.Add(val);
                                  
            }
            if (hs.Contains(0))
                return 1;
            return 0;
        }
        public static int Solve2(List<int> A)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();

            //find last index
            int distance = int.MaxValue;
            for(int i = 0; i < A.Count; i++)
            {
                int val = A[i];
                if (d.ContainsKey(val))
                {
                    int index = d[val];
                    int cd = Math.Abs(index - i);
                    distance = Math.Min(distance, cd);
                    d[val] = i; //update last index
                }
                else
                    d.Add(val, i);
            }
            return distance;
        }
    }
}
