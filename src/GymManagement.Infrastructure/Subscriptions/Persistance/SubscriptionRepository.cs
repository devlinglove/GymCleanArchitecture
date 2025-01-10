

using GymManagement.Application.Common.Interfaces;
using GymManagement.Domain.Subscriptions;
using GymManagement.Infrastructure.Common.Persistance;

namespace GymManagement.Infrastructure.Subscriptions.Persistance
{
	
	public class SubscriptionRepository : ISubscriptionRepository
	{
		private readonly GymManagementDbContext _context;
		public SubscriptionRepository(GymManagementDbContext context)
		{
			_context = context;
		}

		public async Task AddSubscriptionAsync(Subscription subscription)
		{
			await _context.Subscriptions.AddAsync(subscription);
			await _context.SaveChangesAsync();
		}

		public async Task<Subscription?> GetByIdAsync(Guid id)
		{
			var subscription = await _context.Subscriptions.FindAsync(id);
			return subscription;
		}
	}
}
