using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    int t = int.Parse(Console.ReadLine());
        //    while (t-- > 0)
        //    {
        //        var input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
        //        int n = input[0];
        //        int k = input[1];
        //        int b = input[2];
        //        int s = input[3];
        //        var list = new List<int>(n);
        //        int a = s / k;
        //        if (a < b)
        //            Console.WriteLine(-1);
        //        else
        //        {
        //            //possible divide 
        //            var x = s - a;
        //            //var first element
        //            //divide this x
        //            int count = n - 1;
        //            list.Add(x);
        //            //var u = s - x;
        //            var l = k - 1; //max 
        //            var left = a - l;
        //            while (count-- > 0)
        //            {
        //                //var ele = l;
        //                var ele = left >= 0 ? l : 0;                                               
        //               list.Add(ele);
        //                left -= l;
        //            }

        //            if (list.Count == 0)
        //                Console.WriteLine(-1);
        //            else
        //            {
        //                var result = "";
        //                foreach (var xx in list)
        //                    result += xx + " ";
        //                Console.WriteLine(result.Trim());
        //            }
        //        }
        //    }



        //}
        static void Main(string[] args)
        {
            //var x = pow(-1, 2, 20);
            //var x = pow(71045970, 41535484, 64735492);
            //var x = pow(2, 3, 20);
            //var A = new List<int> { -4, 3 };
            //var B = new List<int> { -2, -2 };
            //var x = solve(A, B);
            //var nl = new List<int> { 1, 2, 3, 4, 5 };
            //int B = 9;
            //var nl = new List<int> { 285, 223, 327, 320, 107, 127, 266, 277, 324, 282, 322, 260, 257, 87, 288, 321, 269, 86, 69, 206, 66, 165, 160, 67, 316, 216, 161, 118, 330, 337, 274, 145, 256, 318, 250, 187, 273, 68, 105, 193, 314, 137, 77, 336, 287, 120, 334, 278, 281, 279, 289, 299, 291, 307, 190, 212, 286, 113, 227, 226, 301, 300, 174, 270, 123, 317, 275, 338, 202, 205, 70, 101, 344, 271, 102, 312, 157, 224, 201, 106, 88, 292, 305, 343, 246, 328, 138, 148, 315, 254, 108, 229, 346, 350, 255, 304, 247, 302, 208, 85, 158, 63, 225, 147, 172, 64, 78, 89, 258, 109, 323, 237, 80, 191, 110, 283, 83, 221, 296, 111, 72, 71, 155, 140, 95, 252, 126, 90, 91, 114, 228, 163, 303, 197, 162, 248, 75, 339, 116, 92, 209, 198, 139, 112, 276, 143, 306, 319, 180, 173, 325, 184, 335, 326, 156, 240, 293, 115, 261, 340, 290, 351, 58, 117, 341, 241, 329, 311, 119, 232, 121, 192, 135, 308, 213, 182, 313, 253, 146, 103, 214, 124, 331, 332, 230, 349, 194, 333, 259, 211, 284, 294, 342, 166, 309, 195, 73, 264, 164, 233, 98, 345, 74, 136, 239, 122, 231, 167, 175, 183, 93, 125, 84, 263, 200, 347, 132, 295, 128, 129, 177, 130, 280, 94, 234, 168, 297, 141, 104, 142, 207, 262, 131, 298, 144, 76, 154, 310, 57, 348, 59, 60, 265, 152, 61, 153, 62, 236, 65, 242, 235, 79, 176, 149, 133, 81, 82, 96, 169, 97, 210, 170, 99, 268, 151, 100, 251, 134, 150, 267, 159, 171, 272, 178, 196, 179, 203, 181, 185, 186, 188, 189, 199, 243, 204, 215, 217, 218, 238, 219, 220, 222, 244, 245, 249 };
            var nl = new List<int> { 927, 707, 374, 394, 279, 799, 878, 937, 431, 112 };
            var x = solve(nl);
            Console.WriteLine();
            Console.ReadLine();
        }

        public static int solve(List<int> A)
        {
            ////find 2nd largest
            //int n = A.Count;
            //int k = 2;
            //var y = kthlargest(A, k);
            //var x = A[n - 1];
            ////var y = A[n - 2];
            //while (x != y)
            //{
            //    y = kthlargest(A, k + 1);
            //}
            //return x % y;
            //find 2nd largest
            //find 2nd largest
            int n = A.Count;
            int k = 2;
            var y = kthsmallest(A, k);
            var x = A[n - 1];
            //var y = A[n - 2];
            while (x == y)
            {
                y = kthsmallest(A, k++);
            }


            return x % y;

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
                    if (A[j] < min)
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
        public static int kthlargest(List<int> A, int B)
        {
            //selection sort
            for (int i = 0; i < B; i++)
            {
                int min = A[i];
                int ind = i;

                for (int j = i + 1; j < A.Count; j++)
                {
                    if (A[j] < min)
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
        public static int solve(List<int> A)
        {
            //sort it out
            //will use bubble sort
            for (int i = 0; i < A.Count; i++)
            {
                for (int j = 0; j < A.Count - 1; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        int temp = A[j + 1];
                        A[j + 1] = A[j];
                        A[j] = temp;
                    }
                }
            }
            for (int i = 0; i < A.Count - 1; i++)
            {
                if (A[i + 1] - A[i] != 1)
                    return 0;
            }
            return 1;

        }
        //    public static int kthsmallest(List<int> A, int B)
        //{
        //    //selection sort
        //    for (int i = 0; i < B; i++)
        //    {
        //        int min = A[i];
        //        int ind = i;

        //        for (int j = i + 1; j < A.Count; j++)
        //        {
        //            if (A[j] < min)
        //            {
        //                min = A[j];
        //                ind = j;
        //            }
        //        }
        //        //swap here
        //        int temp = A[ind];
        //        A[ind] = A[i];
        //        A[i] = temp;
        //    }
        //    //inplace yes
        //    //stable no
        //    return A[B - 1];
        //}
        public static List<int> solve(List<int> A, List<int> B)
        {
            var capacity = A.Count + B.Count;
            List<int> l = new List<int>(capacity);

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int m = A.Count;
            int n = B.Count;

            while (p1 < m && p2 < n)
            {
                if (A[p1] < B[p2])
                {
                    l.Add(A[p1]);
                    //p3++;
                    p1++;
                }
                else
                {
                    l.Add(B[p2]);
                    //l[p3] = B[p2];
                    //p3++;
                    p2++;
                }
            }

            //second whiles:-
            while (p1 < m)
            {
                l.Add(A[p1]);
                p1++;
                //p3++;
            }
            while (p2 < n)
            {
                l.Add(B[p2]);
                p2++;
                //p3++;
            }
            return l;
        }

        //static long pow(long a, long b, long c)
        //{
        //    return pow_do(a, b) % c;
        //}
        //static long pow_do(long a, long b)
        //{
        //    if (a == 0) return 0;
        //    if (b == 0) return 1;

        //    return a * pow_do(a, b - 1);
        //}

        //public static int pow(int A, int B, int C)
        //{
        //    decimal result = pow2(A, B, C);
        //    if (result < 0)
        //    {
        //        return (int)(result + C) % C;
        //    }
        //    else
        //        return (int)(result);
        //}
        //public static decimal pow2(decimal A, decimal B, decimal C)
        //{
        //    if (A == 0)
        //    {
        //        return 0;
        //    }
        //    if (B == 0)
        //        return 1;

        //    decimal pow = pow2(A, B / 2, C);

        //    if (((int)B & 1) != 1)
        //        return ((pow % C) * (pow % C)) % C;
        //    else
        //        return ((A % C) * (pow % C) * (pow % C)) % C;

        //}
    }
}
