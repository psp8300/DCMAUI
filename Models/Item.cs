namespace DCMAUI.Models;

public class Item
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
    public int ListId { get; set; }
    public DateTime CreatedAt { get; set; }
}
