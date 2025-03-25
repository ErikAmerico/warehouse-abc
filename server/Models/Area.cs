namespace server.Models;

public class Area
{
    public int Id { get; set; }
    public string Name { get; set; } = "Main";

    public int FloorId { get; set; }
    public required Floor Floor { get; set; } 

    public ICollection<Row> Rows { get; set; } = [];
}
