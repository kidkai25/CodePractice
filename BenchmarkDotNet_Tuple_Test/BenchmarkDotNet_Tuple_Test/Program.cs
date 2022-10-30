using BenchmarkDotNet.Running;
using System;

namespace BenchmarkDotNet_Tuple_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //var summary = BenchmarkRunner.Run<NameParserBenchmarks>();

            Tuple<int, string, string> person = new Tuple<int, string, string>(1, "Steve", "Jobs");
            //Or
            var person2 = Tuple.Create(2, "Mark", "Zuckerburg");

            Console.WriteLine(person2.Item2);
            Console.WriteLine(person2.Item3);
            


        }
    }
}
