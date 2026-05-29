namespace DCMAUI.Models;

public class TeamMemberStatus
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string CurrentActivity { get; set; } = string.Empty;
    public DateTime LastSeen { get; set; }

    public string Initials => Name.Length >= 2
        ? $"{Name[0]}{Name[Name.LastIndexOf(' ') > 0 ? Name.LastIndexOf(' ') + 1 : 1]}".ToUpper()
        : Name.ToUpper();
}
