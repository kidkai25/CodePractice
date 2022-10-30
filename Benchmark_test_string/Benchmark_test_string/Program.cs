using BenchmarkDotNet.Running;
using System;

namespace Benchmark_test_string
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<SingleLineJoin>();
            Console.ReadLine();
        }
    }
}
