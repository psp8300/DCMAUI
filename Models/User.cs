namespace DCMAUI.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public string Token { get; set; } = string.Empty;

    public string Initials => Name.Length >= 2
        ? $"{Name[0]}{Name[Name.LastIndexOf(' ') > 0 ? Name.LastIndexOf(' ') + 1 : 1]}".ToUpper()
        : Name.ToUpper();
}
