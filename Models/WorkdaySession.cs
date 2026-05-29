namespace DCMAUI.Models;

public class WorkdaySession
{
    public DateTime StartTime { get; set; }
    public string Status { get; set; } = string.Empty;
    public double HourlyRate { get; set; }
    public double TotalEarnings { get; set; }
    public TimeSpan ElapsedTime { get; set; }
}
