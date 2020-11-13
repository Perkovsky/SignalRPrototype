using System.Threading.Tasks;

namespace Server.Models
{
	public interface IDashboard
	{
		Task ShowDashboard(DashboardModel dashboard);
	}
}
