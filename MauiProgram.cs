using Microsoft.Extensions.Logging;
using DCMAUI.Services;
using DCMAUI.Views.Login;
using DCMAUI.Views.Dashboard;
using DCMAUI.Views.Lists;
using DCMAUI.Views.Items;
using DCMAUI.Views.Activity;
using DCMAUI.Views.Schedule;
using DCMAUI.Views.Workday;
using DCMAUI.Views.Attendance;
using DCMAUI.Views.LiveStatus;
using DCMAUI.Views.Workforce;

namespace DCMAUI;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        // Services
        builder.Services.AddSingleton<AuthService>();
        builder.Services.AddSingleton<HttpClient>();
        builder.Services.AddSingleton<ApiService>();

        // Pages
        builder.Services.AddTransient<LoginPage>();
        builder.Services.AddTransient<DashboardPage>();
        builder.Services.AddTransient<ListsPage>();
        builder.Services.AddTransient<ItemsPage>();
        builder.Services.AddTransient<ActivityPage>();
        builder.Services.AddTransient<SchedulePage>();
        builder.Services.AddTransient<WorkdayPage>();
        builder.Services.AddTransient<AttendancePage>();
        builder.Services.AddTransient<LiveStatusPage>();
        builder.Services.AddTransient<WorkforcePage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
