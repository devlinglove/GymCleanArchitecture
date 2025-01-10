using GymManagement.Application.Services;
using GymManagement.Application.Subscriptions.Commands.CreateSubscription;
using GymManagement.Contracts.Subscriptions;
using GymManagement.Domain.Subscriptions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GymManagement.Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class SubscriptionsController : ControllerBase
	{
		
		private readonly ISender _sender;

		public SubscriptionsController(ISender sender)
		{
			
			_sender = sender;
		}

		[HttpPost]
		public async Task<IActionResult> CreateSubscription(CreateSubscriptionRequest request)
		{
			//var subscriptionId = _subscriptionsService.CreateSubscription(request.SubscriptionType.ToString(), request.AdminId);

			var subcCommand = new CreateSubscriptionCommand(request.SubscriptionType.ToString(), request.AdminId);

			var subscriptionResult = await _sender.Send(subcCommand);


			return subscriptionResult.MatchFirst(
				subscription => Ok(new SubscriptionResponse(subscription.Id, request.SubscriptionType)),
				error => Problem()
			);

			
		}

	}
}
