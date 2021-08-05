using BenchmarkDotNet.Running;
using BigIntVsInt.BusinessLogic.Boxing;
using BigIntVsInt.BusinessLogic.Configs;
using BigIntVsInt.BusinessLogic.Extensions;
using BigIntVsInt.BusinessLogic.Unboxing;

namespace BigIntVsInt
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var boxingAndUnboxingConfig = BoxingAndUnboxingConfig.Instance;
            var boxingAndUnboxingTypes = new[]
            {
                typeof(BoxingInt32),
                typeof(BoxingBigInteger),
                typeof(UnboxingInt32),
                typeof(UnboxingBigInteger)
            };
            BenchmarkRunner.Run(boxingAndUnboxingTypes.ToBenchmarkInfos(boxingAndUnboxingConfig));
        }
    }
}
