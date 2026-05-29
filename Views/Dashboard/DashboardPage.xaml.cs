using DCMAUI.Services;

namespace DCMAUI.Views.Dashboard;

public partial class DashboardPage : ContentPage
{
    private readonly ApiService _apiService;

    public DashboardPage(ApiService apiService)
    {
        InitializeComponent();
        _apiService = apiService;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await LoadData();
    }

    private async Task LoadData()
    {
        var stats = await _apiService.GetStatsAsync();
        ListsCount.Text = stats.TotalLists.ToString();
        ItemsCount.Text = stats.TotalItems.ToString();
        ActivitiesCount.Text = stats.TotalActivities.ToString();
        EventsCount.Text = stats.UpcomingEvents.ToString();
        LoadingIndicator.IsVisible = false;
        StatsGrid.IsVisible = true;
    }
}
