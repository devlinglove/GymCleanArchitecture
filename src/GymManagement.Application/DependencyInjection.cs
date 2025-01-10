using GymManagement.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GymManagement.Application;

public static class DependencyInjection
{
	public static IServiceCollection AddApplication(this IServiceCollection services)
	{
		//services.AddScoped<ISubscriptionsService, SubscriptionService>();

		services.AddMediatR(options =>
		{
			options.RegisterServicesFromAssemblyContaining(typeof(DependencyInjection));
		});

		//services.AddMediatR(cfg =>
		//    cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));

		return services;
	}

}
