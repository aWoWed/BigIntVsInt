using BenchmarkDotNet.Attributes;
using BigIntVsInt.DataAccess.Models;

namespace BigIntVsInt.BusinessLogic.Unboxing
{
    public class UnboxingInt32
    {
        [Benchmark(Description = "Unboxing Int32 (123)")]
        public int UnboxingInt() => (int)Int32Model.Int32Object;
    }
}
