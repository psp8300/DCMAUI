namespace DCMAUI.Models;

public class ListItem
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int ItemCount { get; set; }
    public string Color { get; set; } = "#6C63FF";
    public DateTime CreatedAt { get; set; }
}
