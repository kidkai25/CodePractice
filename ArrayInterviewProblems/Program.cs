 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInterviewProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> A = new List<int> { 1, 3, 5 };
            //List<int> B = new List<int> { 1, 2, 3 };
            //List<int> C = new List<int> { 5, 6, -1, 7, 8 };
            ////List<int>
            ////C = new List<int> { -4549634, -3196682, 8455838, -1432628, -263819, -3928366, -5556259, -2114783, 3923939, -4183708 };
            ////C = new List<int> { -3674875, 5305422, 7665178, 205505, -7168198, -1398091, 5392310, -1700856, 1259052, -3056006 };
            ////C = new List<int> { -6048887, 5375517, 250742, 4941604, -5351894, -4978897, -1766635, -1563068, -6126256, 7583032 };
            ////C = new List<int> { -5173778, -8176176, 1694510, 7089884, -1394259, 1146372, -2502339, 1544618, 6602022, 4330572 };
            //var x = solve2(C);
            /////////////////////////////////
            int t = 4;
            int boundary = 2 * t;
            int limit = t;
            //int k = boundary;
            int s = 0;
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < limit; j++)
                    Console.Write("*");
                for (int k = 0; k < s; k++)
                    Console.Write(" ");
                for (int k = 0; k < s; k++)
                    Console.Write(" ");
                for (int j = 0; j < limit; j++)
                    Console.Write("*");
                limit--;
                s++;
                Console.WriteLine();
            }
            limit = 1;
            s = s - 1;
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < limit; j++)
                    Console.Write("*");
                for (int k = 0; k < s; k++)
                    Console.Write(" ");
                for (int k = 0; k < s; k++)
                    Console.Write(" ");
                for (int j = 0; j < limit; j++)
                    Console.Write("*");
                s--;
                limit++;
            Console.WriteLine();
            }
            Console.ReadLine();
            //////////////////////////////

            //var y = x;
            //string a = "111011101";
            //a = "010100110101";
            //a = "11100";
            //char[] arr = a.ToCharArray();
            //int[] prefix = new int[arr.Length];
            //int[] suffix = new int[arr.Length];
            //int ans = 0;
            //int total = 0;
            //bool R1 = false;
            //bool L1 = false;
            //int count1 = 0;
            ////building prefix array
            ////111011101
            ////123012301            
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    if (i == 0)
            //    {
            //        if (arr[0] == '0')
            //            prefix[0] = 0;
            //        else
            //        {
            //            count1++;
            //            prefix[0] = 1;
            //        }
            //    }
            //    else
            //    {
            //        if (arr[i] == '0')
            //            prefix[i] = 0;
            //        else
            //        {
            //            count1++;
            //            prefix[i] = prefix[i - 1] + 1;
            //        }
            //    }
            //}
            ////building suffix
            ////111011101
            ////321032101 
            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    if (i == arr.Length - 1)
            //    {
            //        if (arr[i] == '0')
            //            suffix[i] = 0;
            //        else
            //            suffix[i] = 1;
            //    }
            //    else
            //    {
            //        if (arr[i] == '0')
            //            suffix[i] = 0;
            //        else
            //            suffix[i] = suffix[i + 1] + 1;
            //    }
            //}

            ////final loop
            //for (int i = 0; i < arr.Length; i++)
            //{

            //    //int total = 0;
            //    if(arr[i] == '0')
            //    {
            //        //if (i == 0 || i == arr.Length - 1)
            //        //{
            //        //    ans = Math.Max(ans, 1);
            //        //}
            //        //else
            //        int L = (i == 0)? 0 : prefix[i - 1];
            //        int R = (i == arr.Length - 1)? 0:suffix[i + 1];
            //        if (L + R < count1)
            //            ans = Math.Max(ans, L + R + 1);
            //        else
            //            ans = Math.Max(ans, L + R);
            //    }
            //}

            //012012301
            //foreach(var x in suffix)
            //    Console.Write(x + " ");
            //Console.WriteLine(ans);
            Console.ReadLine();
            
        }
        public static int solve(List<int> A, List<int> B)
        {
            int minCost = int.MaxValue;
            
            for (int i = 0; i < A.Count; i++)
            {
                int leftCost = int.MaxValue;
                int rightCost = int.MaxValue;
                //for each element look at left and look at right
                for (int j = 0; j < i; j++)
                {
                    if (A[j] < A[i])
                    {
                        leftCost = Math.Min(leftCost, B[j]);
                    }
                }
                for (int k = i + 1; k < A.Count; k++)
                {
                    if (A[k] > A[i])
                    {
                        rightCost = Math.Min(rightCost, B[k]);
                    }
                }
                if(rightCost != int.MaxValue && leftCost != int.MaxValue)
                minCost = Math.Min(minCost, B[i] + leftCost + rightCost);
            }
            if (minCost == 0)
                return -1;
            return minCost;
        }

        public static List<int> solve2(List<int> A)
        {
            //Creating PreFix sum
            List<int> pre = new List<int>(new int[A.Count]);
            List<int> res = new List<int>();
            for (int i = 0; i < A.Count; i++)
            {
                if (i == 0)
                    pre[0] = A[0];
                else
                    pre[i] = A[i] + pre[i - 1];
            }

            int start = pre[0] < 0 ? 1 : 0;
            int maxSize = -1;

            for (int i = 1; i < A.Count; i++)
            {

                //find low                
                if (pre[i] < pre[i - 1] || i == A.Count - 1)
                {
                    //int size = pre[i - 1] - pre[start];
                    int size = 0;
                    if (i == A.Count - 1)
                    {
                        if (pre[i] < pre[i - 1])
                            size = i - start;
                        else
                            size = i - start + 1; //include last
                    }
                        
                    else
                        size = i - start;
                    if (size > maxSize)
                    {
                        //Add range to List
                        res = A.GetRange(start, size).All(x => x > 0) ? A.GetRange(start,size):res;
                        maxSize = size;
                        
                    }
                    start = i + 1;
                }
            }
            return res;
        }
    }
}
