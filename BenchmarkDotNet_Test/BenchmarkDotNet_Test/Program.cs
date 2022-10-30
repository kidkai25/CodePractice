using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace BenchmarkDotNet_Test
{
    public class Program
    {
        public class LoopBenchmarks
        {
            static int[] arr = new int[100];

            public LoopBenchmarks()
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = i;
                }
            }

            [Benchmark]
            public int ForEachOnArray()
            {
                int sum = 0;

                foreach(var i in arr)
                {
                    sum += i;
                }
                return sum;
            }

            [Benchmark]
            public int ForEachOnIEnumerable()
            {
                int sum = 0;
                IEnumerable<int> arrEnum = arr;

                foreach(int val in arrEnum)
                {
                    sum += val;
                }

                return sum;
            }
        }

        static void Main(string[] args)
        {
            var Summary = BenchmarkRunner.Run<LoopBenchmarks>();
        }
    }
}
