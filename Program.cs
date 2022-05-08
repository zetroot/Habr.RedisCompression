using BenchmarkDotNet.Running;
using Habr.RedisCompression;

_ = BenchmarkRunner.Run<CompressingBenchmarks>();
