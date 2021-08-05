using BenchmarkDotNet.Attributes;
using BigIntVsInt.DataAccess.Models;

namespace BigIntVsInt.BusinessLogic.Boxing
{
    public class BoxingInt32
    {
        [Benchmark(Description = "Boxing Int32 (123)")]
        public object BoxingInt() => (object)Int32Model.Int32;
    }
}