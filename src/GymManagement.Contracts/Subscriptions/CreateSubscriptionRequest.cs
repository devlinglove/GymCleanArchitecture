

namespace GymManagement.Contracts.Subscriptions
{
	public record CreateSubscriptionRequest(SubscriptionType SubscriptionType, Guid AdminId);

	//public class CreateSubscriptionRequest
	//{
	//	public SubscriptionType SubscriptionType { get; init; }
	//	public Guid AdminId { get; init; }

	//	public CreateSubscriptionRequest(SubscriptionType subscriptionType, Guid adminId)
	//	{
	//		SubscriptionType = subscriptionType;
	//		AdminId = adminId;
	//	}
	//}
}
