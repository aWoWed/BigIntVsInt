# BigIntVsInt
Benchmarks of boxing/unboxing Int32 and BigInteger in C#

## BigIntVsInt.DataAccess
The project where the models used in the benchmarks are stored.

`<Type>Models.cs` - file of the certain `<Type>` models.

## BigIntVsInt.BusinessLogic
Project with BL layer. Contains:
* `Extensions` - helper functions;
* `Configs` - configs of benchmark types;
* `Boxing` - boxing benchmarks;
* `Unboxing` - unboxing benchmarks;

## BigIntVsInt
Benchmark launch project. Please start project in `Release Configuration`. Ctrl + F5

## My Configuration
```
BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19041.1110 (2004/May2020Update/20H1)
AMD Ryzen 7 3800X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=5.0.302
  [Host]     : .NET Core 3.1.17 (CoreCLR 4.700.21.31506, CoreFX 4.700.21.31502), X64 RyuJIT
  DefaultJob : .NET Core 3.1.17 (CoreCLR 4.700.21.31506, CoreFX 4.700.21.31502), X64 RyuJIT
```
## My Results
|                                       Method |      Mean |     Error |    StdDev |
|--------------------------------------------- |----------:|----------:|----------:|
|                    'Boxing BigInteger (123)' | 4.2462 ns | 0.0458 ns | 0.0406 ns |
|                         'Boxing Int32 (123)' | 1.6116 ns | 0.0824 ns | 0.0846 ns |
|                  'Unboxing BigInteger (123)' | 1.5411 ns | 0.0365 ns | 0.0341 ns |
|                       'Unboxing Int32 (123)' | 0.0269 ns | 0.0017 ns | 0.0015 ns |
|   'Boxing BigInteger (Int32.MaxValue + 123)' | 4.3703 ns | 0.1234 ns | 0.1154 ns |
| 'Unboxing BigInteger (Int32.MaxValue + 123)' | 1.5113 ns | 0.0168 ns | 0.0157 ns |

