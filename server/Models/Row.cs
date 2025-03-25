namespace server.Models;


public class Row
{
    public int Id { get; set; }
    public string Label { get; set; } = string.Empty;

    public int AreaId { get; set; }
    public required Area Area { get; set; }

    public ICollection<Bay> Bays { get; set; } = [];
}
