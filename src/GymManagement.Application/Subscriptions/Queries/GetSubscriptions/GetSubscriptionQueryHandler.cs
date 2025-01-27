﻿using ErrorOr;
using GymManagement.Application.Common.Interfaces;
using GymManagement.Domain.Subscriptions;
using MediatR;


namespace GymManagement.Application.Subscriptions.Queries.GetSubscriptions
{
	
	public class GetSubscriptionQueryHandler : IRequestHandler<GetSubscriptionQuery, ErrorOr<Subscription>>
	{
		private readonly ISubscriptionRepository _subscriptionRepository;

		public GetSubscriptionQueryHandler(ISubscriptionRepository subscriptionRepository)
		{
			_subscriptionRepository = subscriptionRepository;
		}

		public async Task<ErrorOr<Subscription>> Handle(GetSubscriptionQuery request, CancellationToken cancellationToken)
		{
			var subscription = await _subscriptionRepository.GetByIdAsync(request.SubscriptionId);

			if (subscription == null) {
				return Error.NotFound(description: "Subscription not found");
			}

			return subscription;
		}
	}
}
