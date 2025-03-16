using System.Collections.Concurrent;

namespace BackgroundJobs
{
    public class SampleData
    {
        public ConcurrentBag<string> Data { get; set; } = new ConcurrentBag<string>();
    }
}
