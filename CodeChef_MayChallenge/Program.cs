using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChef_MayChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());

            while (testCase-- > 0)
            {
                string[] input = Console.ReadLine().Split(' ');
                int N = int.Parse(input[0]);
                int x = int.Parse(input[1]);
                int k = int.Parse(input[2]);
                int ballLength = 0;
                bool found = false;
                
                //declare an array of size N + 1
                //int[] myArr = Enumerable.Range(0,N + 1).ToArray();


                if (x % k == 0)
                    Console.WriteLine("YES");
                else
                {
                    ballLength = N + 1;
                    for (int i = 0; i <= N - 1; i++)
                    {
                        ballLength = ballLength - (i * k);
                        if (x == ballLength)
                        {
                            found = true;
                            Console.WriteLine("YES");
                            break;
                        }

                    }
                    if(!found)
                        Console.WriteLine("NO");
                }
                    ////Backwards
                    ////Apply possible Binary Search
                    //var result = binarySearch(myArr, 0, myArr.Length, x, k);
                    //if(result == -1)
                    //Console.WriteLine("NO");
                    //else
                    //    Console.WriteLine("YES");
                
            }
        }
        static int binarySearch(int[] arr, int l,
                             int r, int x, int k)
        {
            if (r >= l)
            {
                int mid = l + (r - l - k) / 2;

                // If the element is present at the
                // middle itself
                if (arr[mid] == x)
                {
                    return mid;
                }

                // If element is smaller than mid, then
                // it can only be present in left subarray
                if (arr[mid] > x)
                    return binarySearch(arr, l, mid - 1, x,k);

                // Else the element can only be present
                // in right subarray
                return binarySearch(arr, mid + 1, r, x,k);
            }

            // We reach here when element is not present
            // in array
            return -1;
        }

    }
}

