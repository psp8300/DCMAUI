using DCMAUI.Services;

namespace DCMAUI.Views.Workday;

public partial class WorkdayPage : ContentPage
{
    private readonly ApiService _apiService;
    private IDispatcherTimer? _timer;

    public WorkdayPage(ApiService apiService)
    {
        InitializeComponent();
        _apiService = apiService;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        var session = await _apiService.GetWorkdaySessionAsync();
        StartTimeLabel.Text = session.StartTime.ToString("hh:mm tt");
        EarningsLabel.Text = $"₹{session.TotalEarnings:N0}";
        StatusLabel.Text = session.Status;
        StartTimer(session.StartTime);
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        _timer?.Stop();
    }

    private void StartTimer(DateTime startTime)
    {
        _timer = Dispatcher.CreateTimer();
        _timer.Interval = TimeSpan.FromSeconds(1);
        _timer.Tick += (s, e) =>
        {
            var elapsed = DateTime.Now - startTime;
            ElapsedLabel.Text = elapsed.ToString(@"hh\:mm\:ss");
        };
        _timer.Start();
    }
}
