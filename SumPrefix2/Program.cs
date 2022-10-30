using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumPrefix2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> A = new List<int>{ 1, 2, 3, 4, 5, 6, 7, 15, 1, 2, 3, 4, 5, 6, 7 };
            int result = solve2(A);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public static int solve(List<int> A)
        {
            //Observation:- Removing an element changes the succeeding index values
            int evenSum = 0;
            int oddSum = 0;
            int count = 0;
            List<int> evenPre = new List<int>();
            List<int> oddPre = new List<int>();
            for (int i = 0; i < A.Count; i++)
            {
                //remove A[i] and then calculate succeed;
                //maintain prefix sum of preceding vals;
                for (int j = i + 1; j < A.Count; j++)
                {
                    //reverse
                    if (j % 2 == 0)
                    {
                        oddSum += A[j];
                    }
                    else
                    {
                        evenSum += A[j];
                    }
                }
                //Calculate total sum even 
                var totalEvenSum = evenPre.Count > 0 ? evenPre[evenPre.Count - 1] + evenSum : evenSum;
                var totalOddSum = oddPre.Count > 0 ? oddPre[oddPre.Count - 1] + oddSum : oddSum;

                if (totalEvenSum == totalOddSum)
                    count++;
                if (i % 2 == 0)
                {
                    //evenPrefix
                    evenPre.Add(evenPre.Count > 0 ?evenPre[evenPre.Count - 1] + A[i] : A[i]);
                }
                else
                {
                    oddPre.Add(oddPre.Count > 0 ? oddPre[oddPre.Count - 1] + A[i] : A[i]);
                }
                //reset
                oddSum = 0;
                evenSum = 0;

            }
            return count;
        }

        public static int solve2(List<int> B)
        {
            //List<int> A = new List<int> { 1, 2, 3, 7, 1, 2, 3 };
            List<int> A = new List<int> { 2,1,6,4 };
            int n = A.Count;
            int[] leftOdd = new int[n], leftEven = new int[n];
            int[] rightOdd = new int[n], rightEven = new int[n];
            int odd = 0, even = 0;
            for (int i = 0; i < n; i++)
            {
                leftOdd[i] = odd;
                leftEven[i] = even;
                if (i % 2 == 0) even += A[i];
                else odd += A[i];
            }
            odd = 0;
            even = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                rightOdd[i] = odd;
                rightEven[i] = even;
                if (i % 2 == 0) even += A[i];
                else odd += A[i];
            }

            return 0;
        }
    }
}
