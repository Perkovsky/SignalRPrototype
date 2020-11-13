using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Server.Models;
using Server.Services;

namespace Server.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class DashboardController : ControllerBase
	{
		private readonly ILogger<DashboardController> _logger;
		private readonly IDashboardService _service;

		public DashboardController(ILogger<DashboardController> logger, IDashboardService service)
		{
			_logger = logger;
			_service = service;
		}

		[HttpGet]
		public DashboardModel Get()
		{
			return _service.Generate();
		}
	}
}
