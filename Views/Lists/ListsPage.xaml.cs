using DCMAUI.Services;

namespace DCMAUI.Views.Lists;

public partial class ListsPage : ContentPage
{
    private readonly ApiService _apiService;

    public ListsPage(ApiService apiService)
    {
        InitializeComponent();
        _apiService = apiService;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        var lists = await _apiService.GetListsAsync();
        ListsCollection.ItemsSource = lists;
    }

    private async void OnNewListClicked(object sender, EventArgs e)
    {
        var name = await DisplayPromptAsync("New List", "Enter list name:");
        if (!string.IsNullOrWhiteSpace(name))
            await DisplayAlert("Success", $"List '{name}' created.", "OK");
    }
}
