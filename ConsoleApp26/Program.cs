using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello");
        //Console.ReadLine();
        List<int> l = new List<int>(){ 9, 4, 9, 1, 5 };
        //l = new List<int>() { 1, 2, 3 };
        l = new List<int>() { 8, 7, 5, 6, 8, 1 };
        var x = solve(l);

        var y = 0;
        Console.WriteLine(x);
        Console.ReadLine();
    }
    public static int solve(List<int> array)
    {
        //generate subsequence
        int count = 1 << array.Count; // 2^n
        long result = 0;
        for (int i = 0; i < count; i++)
        {
            string[] items = new string[array.Count];
            BitArray b = new BitArray(BitConverter.GetBytes(i));
            //result = 0;            
            for (int bit = 0; bit < array.Count; bit++)
            {
                if (b[bit]) {
                    if (!IsPrime(array[bit])){
                        items = new string[0];
                        break;
                    }
                    else
                    {
                        items[bit] = array[bit].ToString();
                    }
                }
                else
                {
                    items[bit] = ""; 
                }                
            }
            if (String.Join("", items).Length >= 1)
            {
                result++;
                Console.WriteLine(String.Join("", items));
            }
        }
        return (int)result % 1000000007;
    }
    public static bool IsPrime(long n)
    {
        if (n <= 1)
            return false;
        for (long i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
}
