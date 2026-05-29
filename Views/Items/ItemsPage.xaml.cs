using DCMAUI.Models;
using DCMAUI.Services;

namespace DCMAUI.Views.Items;

public partial class ItemsPage : ContentPage
{
    private readonly ApiService _apiService;
    private List<Item> _allItems = new();

    public ItemsPage(ApiService apiService)
    {
        InitializeComponent();
        _apiService = apiService;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        _allItems = await _apiService.GetItemsAsync();
        ItemsCollection.ItemsSource = _allItems;
    }

    private void OnSearchChanged(object sender, TextChangedEventArgs e)
    {
        var query = e.NewTextValue?.ToLower() ?? string.Empty;
        ItemsCollection.ItemsSource = string.IsNullOrEmpty(query)
            ? _allItems
            : _allItems.Where(i => i.Name.ToLower().Contains(query) || i.Type.ToLower().Contains(query)).ToList();
    }
}
