using ErrorOr;
using MediatR;

namespace GymManagement.Application.Subscriptions.CreateSubscription;

public record CreateSubscriptionCommand(
    string SubscriptionType,
    Guid AdminId
) : IRequest<ErrorOr<Guid>>;