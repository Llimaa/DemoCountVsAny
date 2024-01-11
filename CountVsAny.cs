using BenchmarkDotNet.Attributes;

namespace DemoCountVsAny;

[MemoryDiagnoser]
[RankColumn]
public class CountVsAny 
{
    private IEnumerable<Client> Clients = null!;
    public CountVsAny()
    {
        Clients = Client.GetClient();
    }
    
    [Benchmark]
    public bool UseCount() 
    {
        return Clients.Count(_ => _.Id == 5) > 0;
    }

    [Benchmark]
    public bool UseAny() 
    {
        return Clients.Any(_ => _.Id == 10);
    }
}
