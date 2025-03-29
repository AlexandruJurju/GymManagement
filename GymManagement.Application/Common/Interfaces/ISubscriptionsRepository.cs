using GymManagement.Domain.Subscriptions;

namespace GymManagement.Application.Common.Interfaces;

public interface ISubscriptionsRepository
{
    Task<bool> ExistsAsync(Guid id);
    Task<Subscription?> GetByAdminIdAsync(Guid adminId);
    Task AddSubscriptionAsync(Subscription subscription);
    Task<Subscription?> GetByIdAsync(Guid id);
    Task RemoveSubscriptionAsync(Subscription subscription);
    Task UpdateAsync(Subscription subscription);
    Task<List<Subscription>> ListAsync();
}