namespace GymManagement.Contracts.Subscriptions
{
	//public class SubscriptionResponse
	//{
	//	public SubscriptionType SubscriptionType { get; init; }
	//	public Guid Id { get; init; }

	//	public SubscriptionResponse(SubscriptionType subscriptionType, Guid id)
	//	{
	//		SubscriptionType = subscriptionType;
	//		Id = id;
	//	}
	//}


	public record SubscriptionResponse(Guid Id, SubscriptionType SubscriptionType);

}
