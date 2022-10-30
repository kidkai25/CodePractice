``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.836 (1909/November2018Update/19H2)
Intel Core i5-7Y54 CPU 1.20GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.201
  [Host]     : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT


```
|               Method |       Mean |    Error |   StdDev |
|--------------------- |-----------:|---------:|---------:|
|       ForEachOnArray |   183.6 ns |  3.74 ns | 10.11 ns |
| ForEachOnIEnumerable | 1,352.2 ns | 26.76 ns | 60.95 ns |
