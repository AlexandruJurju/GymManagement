using GymManagement.Application.Common.Interfaces;
using GymManagement.Domain.Subscriptions;
using GymManagement.Infrastructure.Common.Persistence;
using Microsoft.EntityFrameworkCore;

namespace GymManagement.Infrastructure.Subscriptions.Persistence;

public class SubscriptionsRepository : ISubscriptionsRepository
{
    private readonly GymManagementDbContext _db;

    public SubscriptionsRepository(GymManagementDbContext db)
    {
        _db = db;
    }

    public async Task AddSubscriptionAsync(Subscription subscription)
    {
        await _db.Subscriptions.AddAsync(subscription);
    }

    public async Task<Subscription?> GetByIdAsync(Guid id)
    {
        return await _db.Subscriptions.FirstOrDefaultAsync(x => x.Id == id);
    }
}