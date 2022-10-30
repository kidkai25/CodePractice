using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> l3 = new List<int>{ 20, 3, 13, 5, 10, 14, 8, 5, 11, 9, 1, 11};
            //List<int> l1 = new List<int> { 3, 7, 90, 20, 10, 50, 40 };
            //List<int> l2 = new List<int> { 3, 7, 5, 20, -10, 0, 12 };
            //List<int> l4 = new List<int> { 15, 8, 16 };
            //List<int> l5 = new List<int> { 1, 2, 3, 4, 5 };
            //List<int> l6 = new List<int> { 13, 16, 16, 15, 9, 16, 2, 7, 6, 17, 3, 9 };
            //List<int> l6 = new List<int> { 3, 12, 11, 11, 11, 15 };
            //List<int> l7 = new List<int> { 1, 0, 1, 0, 1 };
            //List<int> l7 = new List<int> { 0, 0, 0, 1, 1, 0, 1 };
            //List<int> l7 = new List<int> { 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 1 };
            List<int> l7 = new List<int> { 0, 0, 1, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 1, 1, 1, 1 };
            //Console.WriteLine(Solve7(l7,1));
            //Console.WriteLine(Solve2(l1,3));
            //Console.WriteLine(Solve2(l2,2));
            var x = Solve7(l7, 2);
            Console.ReadLine();
        }
        //public static int Solve(List<int> A, int B)
        //{
        //    int K = B;
        //    double minAverage = double.MaxValue;
        //    int ans = int.MaxValue;
        //    var n = A.Count;
        //    for (int i = 0; i < n - K; j++)
        //    {
        //        sum += A[j];
        //    }
        //    for (int i = 0; i < A.Count; i++)
        //    {
        //        int sum = 0;
        //        double average = 0;
        //        if (i > n - K )
        //            break;
        //        for (int j = i; j < i + K; j++)
        //        {                    
        //            sum += A[j];
        //        }
        //        average = (double)sum / (double)K;
        //        if (average < minAverage)
        //        {   //update
        //            minAverage = average;
        //            ans = i;
        //        }
        //    }
        //    return ans;

        //}

        //public static int Solve2(List<int> A, int B)
        //{
        //    int K = B;
        //    double minAverage = double.MaxValue;
        //    int ans = int.MaxValue;
        //    var n = A.Count;
        //    int sum = 0;
        //    for (int i = 0; i < n - K; j++)
        //    {
        //        sum += A[i];
        //    }
        //    for (int i = 0; i < A.Count; i++)
        //    {

        //        double average = 0;
        //        if (i > n - K)
        //            break;
        //        for (int j = i; j < i + K; j++)
        //        {
        //            sum += A[j];
        //        }
        //        average = (double)sum / (double)K;
        //        if (average < minAverage)
        //        {   //update
        //            minAverage = average;
        //            ans = i;
        //        }
        //    }
        //    return ans;

        //}

        //public static int solve3(List<int> A, int B)
        //{
        //    int count = 0;
        //    //Brute Force
        //    for (int i = 0; i < A.Count; i++)
        //    {

        //        for (int j = i; j < A.Count; j++)
        //        {
        //            int sum = 0;
        //            for (int k = i; k <= j; k++)
        //            {
        //                sum += A[k];

        //            }
        //        }
        //    }
        //    return count;
        //}
        //public static int Solve4(List<int> A, int B)
        //{
        //    int count = 0;
        //    int length = A.Count;
        //    int[] pre = new int[length];
        //    pre[0] = A[0];
        //    //Prefix sum array
        //    for (int i = 1; i < length; i++)
        //    {
        //        pre[i] = A[i] + pre[i - 1];
        //    }
        //    for (int i = 0; i < length; i++)
        //    {
        //        //15,8,16
        //        //15
        //        //15 + 18
        //        //15 + 8 + 16
        //        //8
        //        //2 6 12 15 17
        //        for (int j = i; j < length; j++)
        //        {
        //            if(i == 0 && j ==0)
        //            {
        //                if (pre[i] < B)
        //                    count++;
        //            }
        //            else
        //            {
        //                if(i == 0)
        //                {
        //                    if (pre[j] < B)
        //                        count++;
        //                }
        //                else if(pre[j] - pre[i - 1] < B)
        //                    count++;
        //            }
        //        }
        //    }
        //    return count;

        //    //return count;
        //}

        //public static int solve5(List<int> A, int B)
        //{

        //    int n = A.Count;
        //    int[] prefix = new int[n];
        //    prefix[0] = A[0];
        //    int goodCount = 0;
        //    //Prefix sum
        //    for (int i = 1; i < n; i++)
        //    {
        //        prefix[i] = A[i] + prefix[i - 1];
        //    }
        //    for (int i = 0; i < n; i++)
        //    {
        //        int sum = 0;
        //        int count = 0;
        //        for (int j = i; j < n; j++)
        //        {
        //            if (i == 0 && j == 0)
        //            {
        //                //check sum
        //                sum = prefix[j];
        //                //count++;
        //            }
        //            else
        //            {
        //                if (i == 0)
        //                {
        //                    sum = prefix[j];
        //                    //count++;  
        //                }
        //                else
        //                {
        //                    sum = prefix[j] - prefix[i - 1];
        //                    //count++;     
        //                }
        //            }
        //            count++;
        //            //check 
        //            if ((count % 2 == 0 && sum < B) || (count % 2 != 0 && sum > B))
        //                goodCount++;
        //        }

        //    }
        //    return goodCount;
        //}

         public static List<int> Solve7(List<int> A, int B)
        {
            int count = 0;
            //subarray size
            int subArrSize = B * 2 + 1;
            List<int> ans = new List<int>();
            int n = A.Count;
            if (B == 0)
            {
                for (int i = 0; i < n; i++)
                    ans.Add(i);
                return ans;
            }
            //if (B % 2 == 0)
            //    return ans; //empty

            for (int i = 0; i <= n - subArrSize; i++)
            {
                int lastStored = -1;
                //int count = 0;
                bool isFailed = false;
                for (int j = i; j < i + subArrSize; j++)
                {
                    //CHECK IS ALTERNATE
                    if(lastStored == A[j])
                    {
                        isFailed = true;
                        break;
                    }
                    else
                    {
                        lastStored = A[j];
                    }

                }
                if(!isFailed)
                {
                    ans.Add((i + (i + subArrSize)) / 2);
                }
            }
            return ans;
        }
    }
}
