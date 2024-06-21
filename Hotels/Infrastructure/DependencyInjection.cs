using Hotels.Infrastructure.Data;
using Hotels.Infrastructure.Interceptors;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotels.Domain.Hotels;
using Hotels.Infrastructure.Domains.Hotels;
namespace Hotels.Infrastructure
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddInfrastructureServices
			(this IServiceCollection services, IConfiguration configuration)
		{
			var connectionString = configuration.GetConnectionString("Database");

			// Add services to the container.
			services.AddScoped<ISaveChangesInterceptor, AuditableEntityInterceptor>();
			services.AddScoped<ISaveChangesInterceptor, DispatchDomainEventsInterceptor>();
			services.AddScoped<IHotelsRepository, HotelsRepository>();

			services.AddDbContext<ApplicationDbContext>((sp, options) =>
			{
				options.AddInterceptors(sp.GetServices<ISaveChangesInterceptor>());
				options.UseSqlServer(connectionString);
			});

			return services;
		}
	}
}
