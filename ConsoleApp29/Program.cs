using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 5, -1, 3, 2, 0};
            //SelectionSort(arr);
            //SelectionSortDesc(arr);
            //arr = new List<int> { 8, 1, 3, 6, 11, 2, 4, 9, 7, 6 };
            //arr = new List<int> { 8, 1, 3, 6, 5};
            var A = new List<int> { 1,2,3,4,5 };
            A = new List<int> { 5, 5, 5 };
            //Merge(arr, 2, 5, 7);

            MergeSort(arr, 0, arr.Count - 1);

            foreach(var x in arr)
                Console.WriteLine(x + " ");

            //for (int i = 0; i < arr.Count - 1; i++)
            //{
            //    if ((arr[i + 1] - arr[i]) != 1)
            //        Console.WriteLine(0);
            //}
            //Console.WriteLine(1);
            //foreach (var x in arr)
            //{
            //    Console.WriteLine(x + " ");
            //}
            //int n = A.Count;
            //int k = 2;
            //var y = kthsmallest(A, k);
            //var x = A[0];
            ////var y = A[n - 2];
            //int counter = 1;
            //while (x == y && counter < n)
            //{
            //    counter++;
            //    if (counter == n)
            //        break;
            //    y = kthsmallest(A, k++);
            //    //counter++;
            //}
            //if (counter == n)
            //    Console.WriteLine(0);

            //Console.WriteLine(y % x);
            Console.ReadLine();
        }
        static void SelectionSort(List<int> arr)
        {
            int n = arr.Count;
            for(int i = 0;  i < n; i++)
            {
                int min = arr[i];
                int ind = i;
                for (int j = i + 1; j < n; j++)
                {
                    if(arr[j] < min)
                    {
                        min = arr[j];
                        ind = j;
                    }
                }
                //swap now
                int temp = arr[i];
                arr[i] = arr[ind];
                arr[ind] = temp;

            }
            //return arr;
        }
        static void SelectionSortDesc(List<int> arr)
        {
            int n = arr.Count;
            for (int i = 0; i < n; i++)
            {
                int max = arr[i];
                int ind = i;

                for (int j = i + 1; j < n; j++)
                {
                    if(arr[j] > max)
                    {
                        max = arr[j];
                        ind = j;
                    }
                }

                //swap
                int temp = arr[i];
                arr[i] = arr[ind];
                arr[ind] = temp;
            }
        }
    
        static void MergeSort()
        {

        }
        static  void Merge(List<int> a, int l, int y, int r)
        {
            int p1 = l;
            int p2 = y;
            int p3 = 0;
            List<int> c = new List<int>(r - l + 1);
            while(p1 < y && p2 <= r)
            {
                if(a[p1] >= a[p2])
                {
                    c.Add(a[p1]);
                    p1++;                    
                }
                else
                {
                    c.Add(a[p2]);
                    p2++;
                }
            }
            //pasting remaining elements
            while(p1 < y)
            {
                c.Add(a[p1]);
                p1++;
            }
            while(p2 <= r)
            {
                c.Add(a[p2]);
                p2++;
            }
            /*xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx*/
            //copy back all elements from temp array to the original array
            for (int i = 0; i < r - l + 1; i++)
            {
                a[i + l] = c[i];
                //r--;
            }            
        }

        static  void MergeSort(List<int> a, int l, int r)
        {
            if (l < r)
            {
                int mid = l + ((r - l) / 2);

                MergeSort(a, l, mid);
                MergeSort(a, mid + 1, r);

                Merge(a, l, mid + 1, r);
            }
            return;
        }
        public static int kthsmallest(List<int> A, int B)
        {
            //selection sort
            for (int i = 0; i < B; i++)
            {
                int min = A[i];
                int ind = i;

                for (int j = i + 1; j < A.Count; j++)
                {
                    if (A[j] > min)
                    {
                        min = A[j];
                        ind = j;
                    }
                }
                //swap here
                int temp = A[ind];
                A[ind] = A[i];
                A[i] = temp;
            }
            //inplace yes
            //stable no
            return A[B - 1];
        }
    }
}
