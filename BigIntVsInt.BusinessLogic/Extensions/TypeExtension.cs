using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace BigIntVsInt.BusinessLogic.Extensions
{
    public static class TypeExtension
    {
        public static BenchmarkRunInfo[] ToBenchmarkInfos<T>(this IEnumerable<T> types, IConfig config) where T : Type =>
            types.Select(type => BenchmarkConverter.TypeToBenchmarks(type, config)).ToArray();
    }
}
