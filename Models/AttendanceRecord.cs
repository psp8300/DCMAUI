namespace DCMAUI.Models;

public class AttendanceRecord
{
    public DateTime Date { get; set; }
    public string Status { get; set; } = string.Empty;
    public string CheckIn { get; set; } = string.Empty;
    public string CheckOut { get; set; } = string.Empty;
    public string NetTime { get; set; } = string.Empty;
    public double Earnings { get; set; }
}
