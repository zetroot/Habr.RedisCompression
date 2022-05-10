using BenchmarkDotNet.Running;
using Habr.RedisCompression;

if(args.Contains("benchmark"))
    _ = BenchmarkRunner.Run<CompressingBenchmarks>();
else if (args.Contains("size"))
{
    var benchmark = new SizeBenchmark();
    await benchmark.Execute(1000);
}
