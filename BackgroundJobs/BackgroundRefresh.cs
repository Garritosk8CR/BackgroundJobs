
namespace BackgroundJobs
{
    public class BackgroundRefresh : IHostedService, IDisposable
    {
        private Timer? _timer;
        private readonly SampleData data;

        public BackgroundRefresh(SampleData data)
        {
            this.data = data;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(AddToCache, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));

            return Task.CompletedTask;
        }

        private void AddToCache(object? state)
        {
            data.Data.Add($"Data added at: {DateTime.Now.ToShortTimeString()}");
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
