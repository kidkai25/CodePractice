using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prefixsum_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //string A = "ABCGAG";
            //char[] arr = A.ToCharArray();
            //int gcount = 0;
            //int result = 0;
            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    if (arr[i] == 'G')
            //        gcount++;
            //    if(arr[i] == 'A')
            //    {
            //        result += gcount;
            //    }
            //}

            //Console.WriteLine(result);
            //Console.ReadLine();
            //List<int> A = new List<int> { 1 ,3};
            //int max_element = A.Max();
            //int min_element = A.Min();
            //int min_index = -1;
            //int max_index = -1;
            //int ans = A.Count;

            //if (min_element == max_element)
            //    Console.WriteLine("1");
            //for(int i = A.Count - 1; i >= 0; i--)
            //{
            //    if(A[i] == max_element)
            //    {
            //        max_index = i;
            //        if(min_index != -1)
            //        {
            //            ans = Math.Min(ans, Math.Abs(min_index - max_index) + 1);
            //        }
            //    }
            //    else if(A[i] == min_element)
            //    {
            //        min_index = i;
            //        if(max_index != -1)
            //        {
            //            ans = Math.Min(ans, Math.Abs(min_index - max_index) + 1);
            //        }
            //    }
            //}
            //Console.WriteLine(ans);
            //Console.ReadLine();

            List<int> A = new List<int> { 0, 1, 0, 1 };
            bool changedState = false; //original
            int ans = 0;
            for(int i = 0; i < A.Count - 1; i--)
            {
                if (changedState)
                {
                    if (A[i] == 1)
                    {
                        ans++;
                        changedState = !changedState;
                    }
                }
                else
                {
                    if (A[i] == 0)
                        ans++;
                    changedState = !changedState;
                }
            }
            return ans;
        }
    }
}
