using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Server.Models;
using System;

namespace Server.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class DashboardController : ControllerBase
	{
		private readonly ILogger<DashboardController> _logger;

		public DashboardController(ILogger<DashboardController> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		public Dashboard Get()
		{
			var rng = new Random();
			return new Dashboard
			{
				C1 = rng.Next(20, 99),
				C2 = rng.Next(100, 800),
				C3 = rng.Next(1, 1000),
				Uuid = Guid.NewGuid().ToString()
			};
		}
	}
}
