using DCMAUI.Services;

namespace DCMAUI.Views.Attendance;

public partial class AttendancePage : ContentPage
{
    private readonly ApiService _apiService;

    public AttendancePage(ApiService apiService)
    {
        InitializeComponent();
        _apiService = apiService;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        var records = await _apiService.GetAttendanceAsync();
        AttendanceCollection.ItemsSource = records;
    }
}
