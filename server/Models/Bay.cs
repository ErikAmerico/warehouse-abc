namespace server.Models;


public class Bay
{
    public int Id { get; set; }
    public int Position { get; set; }

    public int? Level { get; set; }

    public int RowId { get; set; }
    public required Row Row { get; set; }

    public int? OwnerId { get; set; }
    public Owner? Owner { get; set; }

    public ICollection<Item> Items { get; set; } = [];
}
