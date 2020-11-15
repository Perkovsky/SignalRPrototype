using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Server.Services;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Models
{
	public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IHubContext<DashboardHub, IDashboard> _dashboardHub;
        private readonly IDashboardService _service;

        public Worker(ILogger<Worker> logger, IHubContext<DashboardHub, IDashboard> dashboardHub, IDashboardService service)
        {
            _logger = logger;
            _dashboardHub = dashboardHub;
            _service = service;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var dashboard = _service.Generate();
                _logger.LogInformation($"Dashboard => {dashboard}");
                await _dashboardHub.Clients.All.ShowDashboard(dashboard);
                await Task.Delay(1000);
            }
        }
    }
}
