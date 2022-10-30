``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.778 (1909/November2018Update/19H2)
Intel Core i5-7Y54 CPU 1.20GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.201
  [Host]     : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT


```
|              Method |     Mean |    Error |    StdDev |   Median | Rank |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |---------:|---------:|----------:|---------:|-----:|-------:|------:|------:|----------:|
|          StringJoin | 105.3 ns |  2.12 ns |   4.13 ns | 104.7 ns |    1 | 0.0496 |     - |     - |     104 B |
| StringBuilderAppend | 143.7 ns |  2.30 ns |   2.36 ns | 143.4 ns |    2 | 0.0687 |     - |     - |     144 B |
|       Interpolation | 145.1 ns |  2.98 ns |   6.29 ns | 143.8 ns |    2 | 0.0646 |     - |     - |     136 B |
|   StringConcatenate | 145.7 ns |  2.89 ns |   6.76 ns | 144.2 ns |    2 | 0.0648 |     - |     - |     136 B |
|       PlusOperation | 160.6 ns |  7.81 ns |  22.28 ns | 153.3 ns |    3 | 0.0646 |     - |     - |     136 B |
|        StringFormat | 487.0 ns | 48.34 ns | 142.52 ns | 534.7 ns |    4 | 0.0491 |     - |     - |     104 B |
