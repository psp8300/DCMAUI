using DCMAUI.Services;

namespace DCMAUI.Views.Workforce;

public partial class WorkforcePage : ContentPage
{
    private readonly ApiService _apiService;

    public WorkforcePage(ApiService apiService)
    {
        InitializeComponent();
        _apiService = apiService;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        var team = await _apiService.GetTeamStatusAsync();
        WorkforceCollection.ItemsSource = team;
    }
}
