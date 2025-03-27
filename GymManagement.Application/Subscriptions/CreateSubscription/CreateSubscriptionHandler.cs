using ErrorOr;
using MediatR;

namespace GymManagement.Application.Subscriptions.CreateSubscription;

public class CreateSubscriptionHandler : IRequestHandler<CreateSubscriptionCommand, ErrorOr<Guid>>
{
    public async Task<ErrorOr<Guid>> Handle(CreateSubscriptionCommand request, CancellationToken cancellationToken)
    {
        return Error.NotFound();
    }
}