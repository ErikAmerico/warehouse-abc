namespace server.Models;


public class Warehouse
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public ICollection<Floor> Floors { get; set; } = [];
}
