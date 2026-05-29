using DCMAUI.Services;

namespace DCMAUI.Views.LiveStatus;

public partial class LiveStatusPage : ContentPage
{
    private readonly ApiService _apiService;

    public LiveStatusPage(ApiService apiService)
    {
        InitializeComponent();
        _apiService = apiService;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        var team = await _apiService.GetTeamStatusAsync();
        TeamCollection.ItemsSource = team;
    }
}
