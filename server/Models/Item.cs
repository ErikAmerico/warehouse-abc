namespace server.Models;


public class Item
{
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;

    public int BayId { get; set; }
    public required Bay Bay { get; set; }

    public int OwnerId { get; set; }
    public required Owner Owner { get; set; }
}
