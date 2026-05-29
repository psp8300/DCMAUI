using DCMAUI.Services;

namespace DCMAUI.Views.Activity;

public partial class ActivityPage : ContentPage
{
    private readonly ApiService _apiService;

    public ActivityPage(ApiService apiService)
    {
        InitializeComponent();
        _apiService = apiService;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        var activities = await _apiService.GetActivitiesAsync();
        ActivityCollection.ItemsSource = activities;
    }
}
