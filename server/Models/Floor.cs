namespace server.Models;

public class Floor
{
    public int Id { get; set; }
    public int Number { get; set; }

    public int WarehouseId { get; set; }
    public required Warehouse Warehouse { get; set; }

    public ICollection<Area> Areas { get; set; } = [];
}
