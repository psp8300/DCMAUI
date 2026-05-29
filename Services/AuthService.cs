using DCMAUI.Models;

namespace DCMAUI.Services;

public class AuthService
{
    private const string UserKey = "dc_user";
    private User? _currentUser;

    public User? CurrentUser => _currentUser;
    public bool IsLoggedIn => _currentUser != null;

    public AuthService()
    {
        LoadUserFromStorage();
    }

    public async Task<(bool Success, string Message)> LoginAsync(string email, string password)
    {
        await Task.Delay(800);

        if (email == "admin@dclutter.app" && password == "demo123")
        {
            _currentUser = new User
            {
                Id = 1,
                Name = "Admin User",
                Email = email,
                Role = "Admin",
                Token = "demo-token-123"
            };
            SaveUserToStorage();
            return (true, "Login successful");
        }

        return (false, "Invalid email or password");
    }

    public void Logout()
    {
        _currentUser = null;
        SecureStorage.Default.Remove(UserKey);
    }

    private void LoadUserFromStorage()
    {
        try
        {
            var name = Preferences.Default.Get($"{UserKey}_name", string.Empty);
            var email = Preferences.Default.Get($"{UserKey}_email", string.Empty);
            if (!string.IsNullOrEmpty(email))
            {
                _currentUser = new User { Name = name, Email = email };
            }
        }
        catch { }
    }

    private void SaveUserToStorage()
    {
        if (_currentUser == null) return;
        Preferences.Default.Set($"{UserKey}_name", _currentUser.Name);
        Preferences.Default.Set($"{UserKey}_email", _currentUser.Email);
    }
}
