using DCMAUI.Services;

namespace DCMAUI.Views.Schedule;

public partial class SchedulePage : ContentPage
{
    private readonly ApiService _apiService;

    public SchedulePage(ApiService apiService)
    {
        InitializeComponent();
        _apiService = apiService;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        var events = await _apiService.GetScheduleAsync();
        ScheduleCollection.ItemsSource = events;
    }
}
