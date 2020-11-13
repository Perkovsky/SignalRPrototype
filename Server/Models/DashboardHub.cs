using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Server.Models
{
	public class DashboardHub : Hub<IDashboard>
    {
        public async Task SendDashboardToClients(DashboardModel dashboard)
        {
            await Clients.All.ShowDashboard(dashboard);
        }
    }
}
