namespace DCMAUI;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute("login", typeof(Views.Login.LoginPage));
        Routing.RegisterRoute("schedule", typeof(Views.Schedule.SchedulePage));
        Routing.RegisterRoute("attendance", typeof(Views.Attendance.AttendancePage));
        Routing.RegisterRoute("livestatus", typeof(Views.LiveStatus.LiveStatusPage));
        Routing.RegisterRoute("workforce", typeof(Views.Workforce.WorkforcePage));
    }
}
