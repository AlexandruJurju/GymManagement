using Ardalis.SmartEnum;

namespace GymManagement.Domain.Subscriptions;

public class SubscriptionType : SmartEnum<SubscriptionType>
{
    public static readonly SubscriptionType Free = new("Free", 0);
    public static readonly SubscriptionType Starter = new("Starter", 1);
    public static readonly SubscriptionType Pro = new("Pro", 2);

    public SubscriptionType(string name, int value) : base(name, value)
    {
    }
}