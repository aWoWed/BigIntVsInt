using BenchmarkDotNet.Attributes;
using BigIntVsInt.DataAccess.Models;

namespace BigIntVsInt.BusinessLogic.Boxing
{
    public class BoxingBigInteger
    {
        [Benchmark(Description = "Boxing BigInteger (123)")]
        public object BoxingBigInt() => (object)BigIntegerModels.BigInteger1;

        [Benchmark(Description = "Boxing BigInteger (Int32.MaxValue + 123)")]
        public object BoxingBigIntegerMoreThanMaxInt32() => BigIntegerModels.BigInteger2;
    }
}
