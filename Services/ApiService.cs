using DCMAUI.Models;

namespace DCMAUI.Services;

public class ApiService
{
    private readonly HttpClient _httpClient;
    private const string BaseUrl = "https://your-api-url.com/api"; // TODO: replace with real API URL

    public ApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<DashboardStats> GetStatsAsync()
    {
        // TODO: replace with real API call: return await _httpClient.GetFromJsonAsync<DashboardStats>($"{BaseUrl}/stats");
        await Task.Delay(300);
        return new DashboardStats
        {
            TotalLists = 8,
            TotalItems = 47,
            TotalActivities = 23,
            UpcomingEvents = 5
        };
    }

    public async Task<List<ListItem>> GetListsAsync()
    {
        await Task.Delay(300);
        return new List<ListItem>
        {
            new() { Id = 1, Name = "Work Tasks", ItemCount = 12, Color = "#6C63FF", CreatedAt = DateTime.Now.AddDays(-10) },
            new() { Id = 2, Name = "Shopping", ItemCount = 8, Color = "#FF6584", CreatedAt = DateTime.Now.AddDays(-5) },
            new() { Id = 3, Name = "Ideas", ItemCount = 15, Color = "#43C59E", CreatedAt = DateTime.Now.AddDays(-2) },
            new() { Id = 4, Name = "Contacts", ItemCount = 6, Color = "#FFB347", CreatedAt = DateTime.Now.AddDays(-1) },
        };
    }

    public async Task<List<Item>> GetItemsAsync()
    {
        await Task.Delay(300);
        return new List<Item>
        {
            new() { Id = 1, Name = "Project Proposal", Type = "Document", Notes = "Q3 proposal", ListId = 1, CreatedAt = DateTime.Now.AddDays(-3) },
            new() { Id = 2, Name = "John Doe", Type = "Contact", Notes = "Developer", ListId = 4, CreatedAt = DateTime.Now.AddDays(-2) },
            new() { Id = 3, Name = "Buy groceries", Type = "Task", Notes = "", ListId = 2, CreatedAt = DateTime.Now.AddDays(-1) },
        };
    }

    public async Task<List<ActivityItem>> GetActivitiesAsync()
    {
        await Task.Delay(300);
        return new List<ActivityItem>
        {
            new() { Id = 1, Title = "Team Meeting", Type = "Meeting", Duration = "1h 30m", Date = DateTime.Now.AddHours(-2) },
            new() { Id = 2, Title = "Code Review", Type = "Task", Duration = "45m", Date = DateTime.Now.AddHours(-4) },
            new() { Id = 3, Title = "Lunch Break", Type = "Break", Duration = "1h", Date = DateTime.Now.AddHours(-6) },
        };
    }

    public async Task<List<ScheduleEvent>> GetScheduleAsync()
    {
        await Task.Delay(300);
        return new List<ScheduleEvent>
        {
            new() { Id = 1, Title = "Sprint Planning", Type = "Meeting", Date = DateTime.Now.AddDays(1), Time = "10:00 AM", Location = "Conference Room A" },
            new() { Id = 2, Title = "Doctor Appointment", Type = "Appointment", Date = DateTime.Now.AddDays(2), Time = "2:30 PM", Location = "City Hospital" },
            new() { Id = 3, Title = "Submit Report", Type = "Task", Date = DateTime.Now.AddDays(3), Time = "5:00 PM", Location = "" },
        };
    }

    public async Task<WorkdaySession> GetWorkdaySessionAsync()
    {
        await Task.Delay(300);
        return new WorkdaySession
        {
            StartTime = DateTime.Today.AddHours(9),
            Status = "Working",
            HourlyRate = 500,
            TotalEarnings = 2000,
            ElapsedTime = TimeSpan.FromHours(4)
        };
    }

    public async Task<List<AttendanceRecord>> GetAttendanceAsync()
    {
        await Task.Delay(300);
        return new List<AttendanceRecord>
        {
            new() { Date = DateTime.Today, Status = "Present", CheckIn = "9:00 AM", CheckOut = "6:00 PM", NetTime = "9h 0m", Earnings = 4500 },
            new() { Date = DateTime.Today.AddDays(-1), Status = "Present", CheckIn = "9:15 AM", CheckOut = "6:30 PM", NetTime = "9h 15m", Earnings = 4625 },
            new() { Date = DateTime.Today.AddDays(-2), Status = "Absent", CheckIn = "-", CheckOut = "-", NetTime = "0h", Earnings = 0 },
        };
    }

    public async Task<List<TeamMemberStatus>> GetTeamStatusAsync()
    {
        await Task.Delay(300);
        return new List<TeamMemberStatus>
        {
            new() { Id = 1, Name = "Alice Johnson", Status = "Online", CurrentActivity = "Code Review", LastSeen = DateTime.Now },
            new() { Id = 2, Name = "Bob Smith", Status = "Break", CurrentActivity = "Lunch Break", LastSeen = DateTime.Now.AddMinutes(-15) },
            new() { Id = 3, Name = "Carol White", Status = "Offline", CurrentActivity = "", LastSeen = DateTime.Now.AddHours(-1) },
        };
    }
}
