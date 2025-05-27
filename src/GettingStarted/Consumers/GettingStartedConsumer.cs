using System.Threading.Tasks;
using GettingStarted.Contracts;
using MassTransit;
using Microsoft.Extensions.Logging;

namespace GettingStarted.Consumers;

public class GettingStartedConsumer(ILogger<GettingStartedConsumer> logger) :
    IConsumer<HelloMessage>
{
    // private readonly ILogger<GettingStartedConsumer> _logger;

    public Task Consume(ConsumeContext<HelloMessage> context)
    {
        logger.LogInformation("Consumed HelloMessage {Name}", context.Message.Name);

        return Task.CompletedTask;
    }
}