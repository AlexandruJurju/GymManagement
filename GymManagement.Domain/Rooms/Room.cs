namespace GymManagement.Domain.Rooms;

public class Room
{
    public Room(
        string name,
        Guid gymId,
        int maxDailySessions,
        Guid? id = null)
    {
        Name = name;
        GymId = gymId;
        MaxDailySessions = maxDailySessions;
        Id = id ?? Guid.NewGuid();
    }

    private Room()
    {
    }

    public Guid Id { get; private set; }
    public string Name { get; private set; } = null!;
    public Guid GymId { get; private set; }
    public int MaxDailySessions { get; private set; }
}