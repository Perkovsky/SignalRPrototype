using Server.Models;
using System;

namespace Server.Services
{
	public class DashboardService : IDashboardService
	{
		public DashboardModel Generate()
		{
			var rng = new Random();
			return new DashboardModel
			{
				C1 = rng.Next(20, 99),
				C2 = rng.Next(100, 800),
				C3 = rng.Next(1, 1000),
				Uuid = Guid.NewGuid().ToString()
			};
		}
	}
}
