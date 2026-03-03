using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;
    }

    // Task 4: Log khi Start
    public override async Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Trade Service ?ã b?t ??u lúc: {time}", DateTimeOffset.Now);
        await base.StartAsync(cancellationToken);
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        // Task 3: Vòng l?p ch?y m?i 30 giây
        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("?ang ki?m tra folder và x? lý file giao d?ch...");

            // Ngh? 30 giây
            await Task.Delay(TimeSpan.FromSeconds(30), stoppingToken);
        }
    }

    // Task 4: Log khi Stop
    public override async Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Trade Service ?ã d?ng lúc: {time}", DateTimeOffset.Now);
        await base.StopAsync(cancellationToken);
    }
}