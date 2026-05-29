namespace DCMAUI.Models;

public class ActivityItem
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string Duration { get; set; } = string.Empty;
    public DateTime Date { get; set; }
}
