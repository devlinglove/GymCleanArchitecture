using GymManagement.Domain.Subscriptions;
using Microsoft.EntityFrameworkCore;
using System.Reflection;


namespace GymManagement.Infrastructure.Common.Persistance
{
	public class GymManagementDbContext : DbContext
	{
		public GymManagementDbContext(DbContextOptions<GymManagementDbContext> options) : base(options)
		{
		}

        public DbSet<Subscription> Subscriptions { get; set; }

		
	}
}
