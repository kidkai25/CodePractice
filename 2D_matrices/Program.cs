using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> A = new List<List<int>>();
            List<List<int>> B = new List<List<int>>();
            //List<int> A1 = new List<int>() { 1, 2, 3 };
            //List<int> A2 = new List<int>() { 4, 5, 6 };
            //List<int> B1 = new List<int>() { 9, 8, 7 };
            //List<int> B2 = new List<int>() { 6, 5, 4 };
            //A.Add(A1);
            //A.Add(A2);
            //A.Add(new List<int> { 7, 8, 9 });
            //B.Add(B1);
            //B.Add(B2);
            //List<int> A1 = new List<int>() { 1, 2 };
            //List<int> A2 = new List<int>() { 3, 4 };
            //List<int> B1 = new List<int>() { 5,6 };
            //List<int> B2 = new List<int>() { 7,8 };
            //A.Add(A1);
            //A.Add(A2);
            ////A.Add(new List<int> { 7, 8, 9 });
            //B.Add(B1);
            //B.Add(B2);
            List<int> A1 = new List<int>() { 1, 2, 3 };
            List<int> A2 = new List<int>() { 4, 5, 6 };
            List<int> A3 = new List<int>() { 7, 8, 9 };
            A.Add(A1);
            A.Add(A2);
            A.Add(A3);
            //var r = SolveTranpose2(A);
            var r = generateMatrix(4);
            //r.Reverse();
            var x = r;
            Console.ReadLine();
        }
        public static List<List<int>> Solve(List<List<int>> A, List<List<int>> B)
        {
            List<List<int>> result = new List<List<int>>(A.Count);
            //2 matrices of same size
            int r = A.Count;
            int c = A[0].Count;
            for (int i = 0; i < r; i++)
            {
                List<int> l = new List<int>();
                for (int j = 0; j < c; j++)
                {

                    l.Add(A[i][j] + B[i][j]);

                }
                result.Add(l);
            }
            return result;
        }

        public static List<List<int>> Solve2(List<List<int>> A)
        {
            int r = A[0].Count - 1;
            int c = 0;
            int n = A[0].Count;
            int i = 0;
            int j = 0;
            List<List<int>> result = new List<List<int>>();
            while (c < n)
            {
                i = r;
                j = c;
                List<int> l = new List<int>();
                while(i < n && j >= n)
                {
                    l.Add(A[i][j]);
                    i++;
                    j--;
                }
                result.Add(l);
                if(r > 0)
                {
                    r--;
                }
                else
                {
                    c++;
                }
            }
            return result;
        }

        //
//        [
//  [3, 7, 7, 1]
//        [8, 4, 15, 1]
//        [13, 5, 8, 5]
//        [11, 6, 8, 7]
//]

        public static List<List<int>> Solve2a(List<List<int>> A)
        {
            int r = A[0].Count - 1;
            int c = A[0].Count - 1;
            int n = A[0].Count;
            int i = 0;
            int j = 0;
            int k = r;
            List<List<int>> result = new List<List<int>>();
            while (c >= 0)
            {
                i = r;
                j = c;
                int count = 0;
                List<int> l = new List<int>();
                while (j >= 0 && i < n)
                {
                    l.Add(A[i][j]);
                    i++;
                    j--;
                    count++;
                }
                while(count != 3)
                {
                    l.Add(0);
                    count++;
                }
                result.Add(l);
                if (r > 0)
                {
                    r--;
                }
                else
                {
                    c--;
                }
            }
            return result;
        }

        public static List<List<int>> Solve2b(List<List<int>> A)
        {
            int r = 0;
            int c = 0;
            int n = A[0].Count;
            int i = 0;
            int j = 0;
            List<List<int>> result = new List<List<int>>();
            while (r < n)
            {
                i = r;
                j = c;
                int count = 0;
                //Enumerable.Repeat(0, n);
                List<int> l = Enumerable.Repeat(0, n).ToList();
                while (j >= 0 && i < n)
                {
                    l[i] = A[i][j];
                    i++;
                    j--;
                }
                result.Add(l);
                if (c < n - 1)
                {
                    c++;
                }
                else
                {
                    r++;
                }
            }
            return result;
        }


        public static List<List<int>> Solve3a(List<List<int>> A, List<List<int>> B)
        {
            //row of A mxn and B nxp
            int rowSizeA = A.Count;
            int colSizeA = A[0].Count;
            int rowSizeB = B.Count;
            int columnSizeB = B[0].Count;
            

            List<List<int>> result = new List<List<int>>();
            List<int> l = new List<int>();
            for(int i = 0; i < rowSizeA; i++)
            {

                l = new List<int>();
                
                for (int j = 0; j < columnSizeB; j++) //will run 1 time in the example 2x2 2x1 result = 2x1
                {
                    int product = 0;
                    //MxN and NxP
                    for (int k = 0; k < colSizeA; k++)
                    {
                        product += (A[i][k] * B[k][j]);
                    }
                    l.Add(product);
                }
                result.Add(l);
            }

            return result;
        }

        public static List<List<int>> SolveSub(List<List<int>> A, List<List<int>> B)
        {
            int r = A.Count;
            int c = A[0].Count;
            List<List<int>> result = new List<List<int>>();

            for (int i = 0; i < r; i++)
            {
                List<int> l = new List<int>();
                for (int j = 0; j < c; j++)
                {
                    l.Add(A[i][j] - A[i][j]);
                }
                result.Add(l);
            }
            return result;
        }

        public static List<List<int>> SolveTranpose(List<List<int>> A)
        {
            int r = A.Count;
            int c = A[0].Count;
            List<List<int>> result = new List<List<int>>();

            //2 loops
            int i = 0;
            int j = 0;
            List<int> l = new List<int>();
            //List<int> t = 
            while (i < r && j < c)
            {
                if(i == j)
                {
                    //swap
                    

                }
            }
            return null;
        }

        public static List<List<int>> SolveTranpose2(List<List<int>> A)
        {
            int r = A.Count;
            int c = A[0].Count;
            List<List<int>> result = new List<List<int>>();
            //Create lists based on columns 
            for(int i = 0; i < c; i++)
            {
                List<int> l = new List<int>();
                for(int j = 0; j < r; j++)
                {
                    l.Add(A[j][i]);
                }
                result.Add(l);
            }
            return result;
            
        }


       public static List<List<int>> generateMatrix(int A)
       {
            List<List<int>> result = new List<List<int>>();
            int r = A;
            int n = A;
            //intializing
            for (int z = 0; z < r; z++)
            {
                List<int> l = new List<int>(new int[n]);
                result.Add(l);
            }
            int i = 0;
            int j = 0;
            int k = 1;
            int count = 1;
            if(n == 1)
            {
                result[0][0] = 1;
            }
            while (n >= 2)
            {
                while (k <= n - 1)
                {
                    result[i][j] = count++;
                    k++;
                    j++;
                }
                //i = 0
                k = 1;
                while (k <= n - 1)
                {
                    result[i][j] = count++;
                    k++;
                    i++; //row
                }
                //i = n - 1 and j = n-1
                k = 1;
                while (k <= n - 1)
                {
                    result[i][j] = count++;
                    k++;
                    j--;
                }
                k = 1;
                while (k <= n - 1)
                {
                    result[i][j] = count++;
                    k++;
                    i--;
                }
                //first round done
                //next cell :*
                i++;
                j++;
                n = n - 2;
                k = 1;
            }
            if(n%2 == 1)
            {
                result[i][j] = count;
            }
            return result;
       }

    }
}
