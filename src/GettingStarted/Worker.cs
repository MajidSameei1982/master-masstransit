using System.Threading;
using System.Threading.Tasks;
using MassTransit;
using Microsoft.Extensions.Hosting;

namespace GettingStarted;

public class Worker(IBus bus) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
            // await bus.Publish(new HelloMessage
            //     {
            //         Name = "World"
            //     }
            //     , stoppingToken);

            await Task.Delay(1000, stoppingToken);
    }
}