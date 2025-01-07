using System.Text.Json.Serialization;

namespace GymManagement.Contracts.Subscriptions
{
	[JsonConverter(typeof(JsonStringEnumConverter))]
	public enum SubscriptionType
	{
		Free = 0,
		Starter = 1,
		Pro = 2
	}
}
