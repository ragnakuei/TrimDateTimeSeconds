using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using TrimDateTimeSeconds;

namespace TrimDateTimeSecondsVs;

public class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<TestRunner>();
    }
}

// 可以針對不同的 CLR 進行測試
[SimpleJob(RuntimeMoniker.Net48)]        // .net framework 4.8
[SimpleJob(RuntimeMoniker.Net60)]        // .net 6
[MinColumn, MaxColumn]
[MemoryDiagnoser]
public class TestRunner
{
    private readonly DateTime _from = new DateTime(2001, 01, 02, 03, 04, 05, 06);
    private readonly DateTime _to   = new DateTime(2001, 01, 02, 03, 05, 06, 07);

    public TestRunner()
    {
    }

    [Benchmark]
    public void TestMethod1() => new ParkingMinutes01Calculator().Minutes(_from, _to);

    [Benchmark]
    public void TestMethod2() => new ParkingMinutes02Calculator().Minutes(_from, _to);

    [Benchmark]
    public void TestMethod3() => new ParkingMinutes03Calculator().Minutes(_from, _to);

    [Benchmark]
    public void TestMethod4() => new ParkingMinutes04Calculator().Minutes(_from, _to);
}
