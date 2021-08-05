using System.Numerics;
using BenchmarkDotNet.Attributes;
using BigIntVsInt.DataAccess.Models;

namespace BigIntVsInt.BusinessLogic.Unboxing
{
    public class UnboxingBigInteger
    {
        [Benchmark(Description = "Unboxing BigInteger (123)")]
        public BigInteger UnboxingBigIntegerAsInt32() => (BigInteger)BigIntegerModels.BigInteger1Object;

        [Benchmark(Description = "Unboxing BigInteger (Int32.MaxValue + 123)")]
        public BigInteger UnboxingBigIntegerMoreThanMaxInt32() => (BigInteger)BigIntegerModels.BigInteger2Object;
    }
}
