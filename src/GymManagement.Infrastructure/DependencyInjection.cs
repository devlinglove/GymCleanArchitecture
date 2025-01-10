using GymManagement.Application.Common.Interfaces;
using GymManagement.Infrastructure.Common.Persistance;
using GymManagement.Infrastructure.Subscriptions.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GymManagement.Infrastructure;

public static class DependencyInjection
{
	public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfigurationManager config)
	{
		
		services.AddDbContext<GymManagementDbContext>(options =>
		{
			options.UseSqlite("Data source=GymManagement.db");
		});

		services.AddScoped<ISubscriptionRepository, SubscriptionRepository>();
        

        return services;
	}

}
