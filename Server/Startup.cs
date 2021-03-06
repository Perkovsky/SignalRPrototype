using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Server.Models;
using Server.Services;

namespace Server
{
	public class Startup
	{
		public IConfiguration Configuration { get; }

		public Startup(IConfiguration configuration) => Configuration = configuration;

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddCors();
			services.AddSignalR();
			services.AddHostedService<Worker>();
			services.AddControllers();
			services.AddSingleton<IDashboardService, DashboardService>();
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
				app.UseDeveloperExceptionPage();

			app.UseRouting();
			
			app.UseCors(builder => builder
				.AllowAnyOrigin()
				.AllowAnyHeader()
				.AllowAnyMethod()
				.WithOrigins("http://localhost:8080")
				.AllowCredentials()
			);

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
				endpoints.MapHub<DashboardHub>("/hubs/dashboard");
			});
		}
	}
}
