using GymManagement.Domain.Common;

namespace GymManagement.Domain.Admins;

public record SubscriptionDeletedEvent(Guid subscriptionId) : IDomainEvent;