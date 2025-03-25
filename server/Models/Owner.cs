namespace server.Models;


public class Owner
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public ICollection<Bay> Bays { get; set; } = [];
    public ICollection<Item> Items { get; set; } = [];
}
